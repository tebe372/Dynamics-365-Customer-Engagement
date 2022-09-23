---
title: View the accuracy and performance of predictive scoring models
description: Accuracy of the predictive model is determined by running the model on historical data and calculating false positives, false negatives, true positives, and true negatives.
ms.date: 08/26/2022
ms.custom:
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# View the accuracy and performance of a predictive scoring model

Knowing the accuracy of a predictive scoring model is important to decide whether the model is ready for use or you need to fine tune it for better accuracy. It also helps you to convince the leadership team and sellers to adopt the model for improved business outcomes.

> [!NOTE]
> The metrics described in this article apply to both opportunity scoring and lead scoring.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Factors influencing accuracy

A predictive scoring model calculates the likelihood of an opportunity or lead converting into a sale. The accuracy of the model depends on the following factors:

- Quality and size of the data available for training the model. The model is only as good as the data fed into it.  

- Selection of business process flow and appropriate filters.  
- Stages and attributes chosen, if the model is enabled for per stage modeling.  

After a model is trained, the model runs on the closed opportunities/leads in the training data and verifies the predictions against the actual data. The accuracy of the model is then calculated based on various parameters such as true positives, false positives, and so on.  

> [!NOTE]
> The model is trained using 80% of your closed opportunities/leads and then validated using the remaining 20% as test opportunities/leads, which are the most recent ones.

## View accuracy and performance metrics  

1. Go to **Change area** in the lower-left corner of the Sales Hub app, and select **Sales Insights settings**.

2. On the site map under **Predictive models**, select **Opportunity scoring** or **Lead scoring**.

1. From the **Select model** drop-down, select the model for which you want to view the performance metrics.

2. Select the **Performance** tab.  
    > [!NOTE]
    > If you don't see any metrics in the **Performance** tab, [edit and retrain the model](configure-predictive-opportunity-scoring.md#edit-and-retrain-a-model). 

    The performance metrics of the model are displayed.

    :::image type="content" source="media/predictive-scoring-accuracy.PNG" alt-text="A screenshot of the Performance tab displaying model accuracy metrics":::

     - **Model Performance**  
        Specifies whether the model is ready to publish based on the following parameters:
        
        - **Accuracy**  
            Indicates how often your model makes correct predictions, either as positive or negative. This metric is most useful when the dataset is balanced, and the cost of false positives and false negatives is the same. The accuracy score is calculated using the following formula:
            
            Accuracy = (TP + TN) / (Total number of opportunities/leads scored) *100

        - **Recall**  
            Indicates how often the model predicted a positive outcome correctly compared to the actual positives. A low recall score means the model is predicting fewer true positives. The recall score is calculated using the following formula:

            Recall = TP / (TP + FN) * 100     

        - **Conversion rate**  
            Displays the percentage of opportunities/leads that are actually qualified/won as per historical data. This rate indicates the likelihood that an opportunity or lead will convert. This value is referenced by the model to determine how an attribute will influence the predictive score. The conversion rate is calculated using the following formula:
            
            Conversion rate = (TP + FN) / (Total number of opportunities/leads scored) *100

    - **Confusion matrix**  
        Indicates how well your model is able to predict the outcomes when it was tested against historical data. The matrix displays the number of true positives, true negatives, false positives, and false negatives.

        
        |Metric  |Predicted  |Actual  |
        |---------|---------|---------|
        |True positive (TP)     |    Yes     | Yes        |  
        |True negative (TN)    |    No    |   No      |  
        |False positive (FP)     |   Yes      | No        |
        |False negative (FN)    |   No      |  Yes       |  

    - **Area under the curve**  
        Displays the area under the curve (AUC) score of the model. The AUC score determines the probability that a model will rank a randomly chosen positive instance (a won opportunity or lead) higher than a randomly chosen negative one (a lost opportunity or lead). A model with higher AUC is better at predicting true positives and true negatives.  

    - **F1 score**  
        Displays the F1 score calculated based on the model's precision and recall scores. The F1 score lets you determines the quality of the model even in instances of data imbalance.  

    - **Threshold**  
        Defines the threshold at which the lead or opportunity is considered as qualified/won. For example, if your threshold is 45, opportunities with a score greater than 45 will be predicted as won. The threshold is selected to optimize the F1 score. 

## Example: Model performance metrics
 
Let's understand the metrics with an example dataset of 1000 opportunities:

|Data  |Number of opportunities  |
|---------|---------|
|True positives     |650 |
|False positive     |200         |
|True negatives     |    100     |
|False negative     |  50       |    

The above data means that the system predicted 850 opportunities (TP+FP) to be won, however only 650 opportunities were actually won. Similarly, the system predicted 150 opportunities to be lost but only 
100 opportunities were lost. Let's look at the metrics for this data.

|Metric  |Score  |
|---------|---------|
|Accuracy     |  (650 + 100) / 1000 = 75%       |
|Recall     |  650 / (650 + 50) = 92%       |
|Conversion rate     | (650 + 50) / 1000 = 70%       |


## Improve model performance

If your model is not ready to publish, take the following actions to retrain the model and improve the scores:

- [Edit the model](configure-predictive-opportunity-scoring.md#edit-and-retrain-a-model) to
    - View the attributes used by the model.
    - View attribute insights to understand their influence on the overall prediction.
    - Ignore empty values for attributes that have higher percentage of empty values and hence are resulting in false positives or false negatives.
    - Use intelligent fields to help the model to better understand records and distinguish between score improvers and harmers.
 
- [Add a model](configure-predictive-opportunity-scoring.md#add-a-model) to
    - Use per stage modeling to choose attributes applicable for each business process stage.
    - Refine the filter criteria, time period for training data, or other model configurations. For example, if you've chosen 2 years time period for training data and you realize that you have too many test or incorrect data during that period, choose a lesser time period, 6 months or 1 year, when the quality of data is better.  

### See also

[Configure predictive lead scoring](configure-predictive-lead-scoring.md)  
[Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md)
