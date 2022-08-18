---
title: "FAQ about the voice channel | MicrosoftDocs"
description: "This article includes frequently asked questions (FAQ) about the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/18/2022
ms.topic: article

---

# FAQ about the voice channel in Omnichannel for Customer Service

This topic contains frequently asked questions (FAQ) about the voice channel.

### Does the voice channel include real-time keyword recognition or sentiment tracking while an agent is on a call?

Yes, features such as sentiment analysis, agent suggestions for similar cases or knowledge articles, are available in the voice channel.

### Is the voice channel PCI DSS compliant?

The voice channel is compliant with Payment Card Industry Data Security Standard (PCI DSS) today, but support for credit card data capture over voice isn't yet available. Agents have the ability to pause or resume call recording and transcription to avoid capturing sensitive information. Agents can also pause transcription to avoid dual-tone multi-frequency (DTMF) tones being captured in the transcript. All data is stored in Dynamics 365 and can be scrubbed by the customer.

### Where does Azure Communication Services provide native PSTN services?

Getting registered as a calling provider is a legally complex and country-specific process. Azure Communication Services has a multiyear roadmap to provide calling plans in different countries and regions. As of January 2022, Azure Communication Services provides toll-free and local numbers for those with billing postal codes in United States, Puerto Rico, United Kingdom, and Ireland.

An alternative to Microsoft calling plans is Azure direct routing that allows customers to bring their own phone numbers. More information: [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept)

### What about countries where Azure Communication Services doesn't provide native PSTN services?

Azure Communication Services is available worldwide, even if it isn't acting as the calling provider in certain countries. For these countries, Azure Communication Services provides a direct routing for local carriers, such as AT&T and Verizon, to connect to Azure Communication Services. With this mechanism, you'll still be able to deploy and use all the features of the voice channel in Dynamics 365.

### What codecs are implemented in the voice channel?

The voice channel supports the G.711 and Opus codecs for PSTN and VoIP services.

### Can I bring my own phone number?

Yes, you have the following two options to bring your existing numbers to Omnichannel for Customer Service:

- **Import numbers to Omnichannel for Customer Service**. To do this:
    1. You must first port your existing phone numbers to Azure Communication Services. More information: [Quickstart: Port a phone number into Azure Communication Services](/azure/communication-services/quickstarts/telephony/port-phone-number)
    2. You can then import the phone numbers from Azure Communication Services to Omnichannel for Customer Service. More information: [Sync from Azure Communication Services](voice-channel-sync-from-acs.md)

- **Configure Azure direct routing**. You can configure a Session Border Controller (SBC) that's connected to your local carrier with Azure Communication Services, and then register the phone number in Dynamics 365. More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)
 
### How can I acquire additional phone numbers from Azure Communication Services?

You can purchase one phone number per tenant for Azure Communication Services through the Azure portal. To acquire phone numbers in bulk or request a specific phone number, follow the instructions to create a special number request order [here](https://github.com/Azure/Communication/blob/master/special-order-numbers.md).

### Can I keep my existing contract with my carrier?

Yes, you can.

### Can I configure a third-party voice provider in Omnichannel for Customer Service?

Yes, you can use the Dynamics 365 Channel Integration Framework 2.0 connector to integrate third-party contact centers, such as Genesys Engage, Solgari, and NICE inContact.

### Does the voice channel tie in with Azure Communication Services or is it an entirely different technology?

The voice capabilities for Dynamics 365 Customer Service are built on Azure Communication Services.

### Do I have to buy phone numbers from Azure Communication Services?

No, you don't have to. You can bring phone numbers from another carrier to use in the voice channel using Azure direct routing. More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)

If you have already brought numbers from another carrier into Microsoft Teams via Azure direct routing, then you can reuse your SBC and existing telephony infrastructure to bring those numbers into Azure Communication Services for use in the voice channel.  

> [!Note]
> Currently, you can't bring native Teams phone numbers to use in the voice channel.

### Is it possible to enable voice integrations outside of the Omnichannel for Customer Service app? For example, by adding omnichannel capabilities to a customer Dynamics 365 app.

The voice channel is supported only in the Customer Service workspace and Omnichannel for Customer Service apps.

### How can I set up an IVR bot in the voice channel?

See the following topics to set up the interactive voice response (IVR) bot in the voice channel:
- [Configure Power Virtual Agents bots for voice](voice-channel-ivr-bots.md)
- [Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)

### Should the language of the bot be the same as the primary language configured in the Customer Service admin center or Omnichannel admin center app?
 
Yes, the language of the bot must be the same as that of the voice workstream to which the bot will be attached.

### Can I recover a voice trial after it's no longer provisioned?

No, you can't recover your data and trial phone numbers after the trial organization has expired and been deprovisioned.

### Is disaster recovery supported for the voice channel?

- Business Continuity and Disaster Recovery (BCDR) for production instances of the voice channel are supported on a geographical basis. In certain regions BCDR will be a fast follow. For details on the geographies that are currently supported and the geographies where BCDR is a fast follow, see [Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md).
- In supported regions, BCDR policies are based upon business continuity and disaster recovery for Dynamics 365 and SLA for Azure Communication Services. For more information, see [Business continuity and disaster recovery](/power-platform/admin/business-continuity-disaster-recovery) and [SLA for Azure Communication Services](https://azure.microsoft.com/support/legal/sla/communication-services/v1_0/).

### Do we provide voice quality SLA for voice in Omnichannel for Customer Service?

We do not publish a voice quality SLA - there are many other factors that comprise voice quality that can't be controlled, such as Internet connection, LTE, and 5G. The [SLA](https://azure.microsoft.com/support/legal/sla/communication-services/v1_0/) published for Azure Communication Services applies to the voice channel as well.

### What tools are available to isolate performance and quality of voice channel?

The tools to isolate voice performance and quality are available through Azure Communication Services and can be found at [Azure Communication Services media quality metrics](/azure/communication-services/concepts/voice-video-calling/media-quality-sdk).

More information:

- [Enable Azure Communication Services logs](/azure/communication-services/concepts/troubleshooting-info?tabs=csharp%2Cjavascript%2Cdotnet)
- [Turn on metrics to populate in Azure](/azure/communication-services/concepts/analytics/call-logs-azure-monitor)
- [Integrate with user-facing diagnostics](/azure/communication-services/concepts/voice-video-calling/user-facing-diagnostics)
- [Use media quality statistics](/azure/communication-services/concepts/voice-video-calling/media-quality-sdk)
- [Use pre-call diagnostics](/azure/communication-services/concepts/voice-video-calling/pre-call-diagnostics)
- [Use Azure Communication Services communication monitoring plug-in](https://www.npmjs.com/package/@azure/communication-monitoring)

### Does the voice channel support emergency calling?

Yes, the voice channel supports emergency calling; agents can call the emergency number during a crisis. This feature is currently supported in the United States and Puerto Rico where the emergency calling number is 911. More information: [How emergency calling works in the voice channel](voice-channel-emergency-calling.md)

### See also

[Introduction to the voice channel](voice-channel.md)  
[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  
