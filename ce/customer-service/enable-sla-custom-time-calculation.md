---
title: "Enable custom calculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom calculation of SLA KPIs in Dynamics 365 Customer Service."
ms.date: 04/04/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Enable custom time calculation of SLA KPIs

## Introduction

This topic describes how you can override the default time calculation.

Time calculation in service-level agreements (SLAs) calculates the `WarningTime` and `FailureTime` of SLA key performance indicators (KPIs), taking into consideration input parameters, such as `ApplicableFrom` (StartTime of type DateTime field), `CalendarId` (GUID), and `Duration` (warning duration or failure duration in minutes). The final `WarningTime` or `FailureTime` is calculated based on the customer service schedule and the holiday schedule associated with the SLA item.

In addition to warning and failure time, the elapsed time is also calculated if there is a pause and resume scenario configured for the SLA. To ignore the working hours spent during the paused state of the SLA KPI, the elapsed time gets added to the final failure time.

To change the default time calculation and enable your own custom time calculation, you can define an API interface that has a fixed set of input and output parameters and add a custom logic to calculate the time.

## Enable custom time calculation of SLA KPIs

1. Go to **Settings** > **Customization** > **Customize the system** > **Processes** > **New**.
1. In the **Create Process** dialog, enter the following details:
    1. Enter a process name, for example, CustomPluginTime Calculation.
    1. From the **Category** dropdown list, select **Action** .
    1. From the **Entity** dropdown list, select **None (global)**. 
    1. Select the **New process from an existing template (select from the list)** option.
    1. Select the **SLACustomTimeCalculationTemplate** template from the list.
    1. Select **OK**.

    :::image type="content" source="media/custom-time-cal-template.png" alt-text="Custom time calculation template":::

1. On the template, add the required parameters.

    :::image type="content" source="media/add-sla-process-arguments.png" alt-text="Enable the process arguments for any SLA item":::

1. Write the plug-in and link it to the custom action created in step 2. For more information, go to: [Write a plug-in](/powerapps/developer/data-platform/write-plug-in). To select the plug-in that you need, go to [Scenarios and plug-ins](#scenarios-and-plug-ins), later in this topic.
1. Associate the the previously created custom action with the SLA Item for which you need to perform the default time calculation.
1. Edit the relevant SLA item. In the **General** section, set the **Allow Custom Time Calculation** toggle to **Yes**.
1. From the **Custom Time Calculation API** field, select the custom action you created in step 2, and then select **Save**.
1. Activate your SLA, and apply it to the required entity. The warning and failure time of the SLA KPI appears in accordance with the time calculation logic provided in the custom action.

If you need to export the solution to another environment, you can first add the SLA (whose item has the custom action reference) to the custom solution. This will also import the custom action workflow process. Next, include the SDK message in the solution. This will import the plug-in you created earlier.

### Scenarios and plug-ins

Refer to the following scenarios and their plug-ins to implement a plug-in code associated with your custom action.

Scenario 1:

If you don't have a pause or resume scenario, only the `WarningTime` and `FailureTime` are to be calculated. Whenever any new KPI instances get created, SLA initiates the custom time calculation API to calculate only `WarningTime` and `FailureTime` in a single call.

In such a case, `requestType` will be `getEndTime`, and other attributes can be fetched as defined in the following example:

```
public void Execute(IServiceProvider serviceProvider)
{

	IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
	IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
	_service = factory.CreateOrganizationService(context.UserId);

	// Step 1: Retrieving Input Parameters.
	string regardingId = context.InputParameters["regardingId"] as string;
	string calendarId = context.InputParameters["calendarId"] as string;
	string requestType = context.InputParameters["requestType"] as string;
	string slaItemId = context.InputParameters["slaItemId"] as string;
	string entityName = context.InputParameters["entityName"] as string;
	

	try
	{
		// implement this requestType for any new SLA KPi instance creation.
		if (requestType.Equals("getEndTime", StringComparison.CurrentCultureIgnoreCase))
		{
			int warningDuration = (int)context.InputParameters["firstInputDuration"];
			int failureDuration = (int)context.InputParameters["secondInputDuration"];
			DateTime warningStartTime = (DateTime)context.InputParameters["firstInputDate"];
			DateTime failureStartTime = (DateTime)context.InputParameters["secondInputDate"];

			// Step 2 : Add the custom Logic to calculate the WarningTime and FailureTime
			string returnCalendarId = CalculateWarningAndFailureTime(regardingId, calendarId, slaItemId, entityName, warningStartTime, failureStartTime, warningDuration, failureDuration, out DateTime warningTime, out DateTime failureTime);

			// Step 3 : return the output values.
			context.OutputParameters["firstOutputValue"] = DateTime.SpecifyKind(warningTime, DateTimeKind.Utc).ToString();
			context.OutputParameters["secondOutputValue"] = DateTime.SpecifyKind(failureTime, DateTimeKind.Utc).ToString();
			context.OutputParameters["returnCalendarId"] = returnCalendarId;			
			return;
		}

		// implement this requestType for finding Paused time for any new SLA KPi instance after it resumed.
		if (requestType.Equals("getElapsedTime", StringComparison.CurrentCultureIgnoreCase))
		{
			DateTime casePausedTime = (DateTime)context.InputParameters["firstInputDate"];
			DateTime caseResumedTime = (DateTime)context.InputParameters["secondInputDate"];
			int existingElapsedTime = (int)context.InputParameters["firstInputDuration"];
			// Step 2 : Add the custom Logic to calculate the elapsedTime between startTime(paused) and endTime(resumed)
			double elapsedTimeInMinutes = CalculateElapsedTime(regardingId, calendarId, slaItemId, entityName, casePausedTime, caseResumedTime, existingElapsedTime);

			// Step 3 : return the output values.
			context.OutputParameters["firstOutputValue"] = elapsedTimeInMinutes.ToString();
			context.OutputParameters["secondOutputValue"] = elapsedTimeInMinutes.ToString();			
			return;
		}
	} catch (Exception ex) {
		return;			
	}

	throw new Exception("Invalid requestType:" + requestType+ " for entityName:" + entityName + " of id:" + regardingId);
}

// in this example, we're using Custom Field(new_country) on the Case entity to apply the required calendar.

private string CalculateWarningAndFailureTime(string regardingId, string calendarId, string slaItemId, string entityName, DateTime warningStartTime, DateTime failureStartTime, int warningDuration, int failureDuration, out DateTime warningTime, out DateTime failureTime)
{
	OrganizationResponse customizedTimeCalculationResponse;
	warningTime = DateTime.UtcNow;
	failureTime = DateTime.UtcNow;
	int newWarningTime = warningDuration;
	int newFailureTime = failureDuration;
	int customCode = 0;

	// Step 1: fetch the Case Entity record	
	Entity caseRecord = FetchCaseRecord(entityName, regardingId);

	if (caseRecord.Attributes.Contains("new_country"))
	{
		customCode = (int)(((OptionSetValue)(caseRecord.Attributes["new_country"])).Value);

		// Example 1: Override calendar at runtime: Choose Calendar based on any custom logic
		if (customCode == 0)
		{
			// fetch IST calendar & override CalendarId
			IST_CALENDAR = FetchCalendar("IST_CALENDAR", _service);
			calendarId = IST_CALENDAR;
		}
		else if (customCode == 1)
		{
			// fetch PST calendar & override CalendarId
			PST_CALENDAR = FetchCalendar("PST_CALENDAR", _service);
			calendarId = PST_CALENDAR;
		}		
	}
	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
	
	requestTimeCalculation["requestType"] = "getEndTime";
	requestTimeCalculation["calendarId"] = calendarId;

	// calculate warning time
	if (warningDuration != -1)
	{
		requestTimeCalculation["startTime"] = warningStartTime;
		requestTimeCalculation["minutes"] = newWarningTime;
		customizedTimeCalculationResponse = _service.Execute(requestTimeCalculation);
		customizedTimeCalculationResponse.Results.TryGetValue("returnValue", out object outputValue1);
		warningTime = DateTime.SpecifyKind(DateTime.Parse((string)outputValue1), DateTimeKind.Utc);
	}

	// calculate Failure time
	if (failureDuration != -1)
	{
		requestTimeCalculation["startTime"] = failureStartTime;
		requestTimeCalculation["minutes"] = newFailureTime;
		customizedTimeCalculationResponse = _service.Execute(requestTimeCalculation);
		customizedTimeCalculationResponse.Results.TryGetValue("returnValue", out object outputValue2);
		failureTime = DateTime.SpecifyKind(DateTime.Parse((string)outputValue2), DateTimeKind.Utc);				
	}

	return calendarId;
}

```

Scenario 2:

If there is a pause or resume scenario, the following calculations are to be made:

- Calculation of `elapsedTime` between paused and resumed states.
For this scenario, the SLA invokes the custom time calculation API to calculate the elapsed time between the pause and resume. In such a case, the requestType will be `getElapsedTime` and other attributes can be fetched as defined in the plug-in code example.
- Calculation of new `WarningTime` and `FailureTime` computation for resumed instances. In this case, `requestType` will be `getEndTime` and other attributes can be fetched as defined in the following example:

```
private double CalculateElapsedTime(string regardingId, string calendarId, string slaItemId, string entityName, DateTime casePausedTime, DateTime caseResumedTime, int existingElapsedTime)
{
	OrganizationResponse customizedTimeCalculationResponse;

	// Step 1: fetch the Case Entity record	
	Entity caseRecord = FetchCaseRecord(entityName, regardingId);

	// Example 1: Override calendar at runtime: Choose Calendar based on any custom logic
	if ((int)(((OptionSetValue)(caseRecord.Attributes["new_country"])).Value) == 0)
	{
		// fetch IST id
		IST_CALENDAR = FetchCalendar("IST_CALENDAR", _service);
		calendarId = IST_CALENDAR;
	}
	else if ((int)(((OptionSetValue)(caseRecord.Attributes["new_country"])).Value) == 1)
	{
		// fetch PST  id
		PST_CALENDAR = FetchCalendar("PST_CALENDAR", _service);
		calendarId = PST_CALENDAR;
	}

	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
	requestTimeCalculation["startTime"] = casePausedTime;
	requestTimeCalculation["endTime"] = caseResumedTime;
	requestTimeCalculation["requestType"] = "getElapsedTime";
	requestTimeCalculation["calendarId"] = calendarId;

	// calculate elapsed time
	customizedTimeCalculationResponse = _service.Execute(requestTimeCalculation);
	customizedTimeCalculationResponse.Results.TryGetValue("returnValue", out object outputValue1);
	double totalElapsedTime = existingElapsedTime + Double.Parse(outputValue1.ToString());
	return totalElapsedTime;
}
```

## FAQs
For answers to frequently asked questions about custom time calculation of SLA KPIs, go to [FAQ about custom time calculation of SLA KPIs](faqs-custom-time-sla-kpis.md#).

### See also

[Define service-level agreements](define-service-level-agreements.md)  
[Apply SLAs](apply-slas.md#apply-slas)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
