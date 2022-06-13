---
title: "Enable voice consult with Microsoft Teams user for the voice channel | MicrosoftDocs"
description: "Learn how to enable the consult experience between a voice channel agent and a Microsoft Teams user in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/02/2021
ms.topic: article

---

# Enable voice consult with Microsoft Teams users

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Customer service is not always limited to contact centers. Employees within the enterprise are often required to assist agents in customer service scenarios and talk to customers directly for highly technical or VIP engagements. You can enable your agents to consult with or transfer voice calls in Omnichannel for Customer Service to subject matter experts (SMEs) in Microsoft Teams.

The SMEs can participate in customer service conversations directly from Microsoft Teams to help agents in Dynamics 365 and customers on the phone call to resolve issues expertly.

## Prerequisites

The following prerequisites must be set for the Microsoft Teams users:

- **Assign phone numbers to SMEs in Microsoft Teams**: Must have a phone number assigned to them in Microsoft Teams to participate in the voice call as an SME consult. More information: [Assign, change, or remove a phone number for a user](/microsoftteams/assign-change-or-remove-a-phone-number-for-a-user)

- **Update the Azure profile for SMEs with phone number**: Add SMEs as guest users to the Azure Active Directory for them to participate in a Teams voice call. To add a guest user and update a phone number in the user profile, perform the following steps:

     1. Add a guest user in the Azure portal. More information: [Add a new guest user](/azure/active-directory/external-identities/b2b-quickstart-add-guest-users-portal#add-a-new-guest-user-in-azure-ad)
     2. On the guest user profile page, select **Edit** to add the phone number in the **Contact info** > **Office phone** field.

  Dynamics 365 uses Graph API to retrieve the number in the **Office phone** field. Agents can then search for and add a user to the phone call.

## Enable agents to consult with Microsoft Teams users

To allow the agents to consult with Microsoft Teams users, you'll need to enable the **Consult with Microsoft Teams user** setting in the voice channel section of the workstream for voice. More information: [Configure the voice channel](voice-channel-route-queues.md#configure-a-voice-channel)

### See also

[Introduction to the voice channel](voice-channel.md)  
[Agent consult with Microsoft Teams users](voice-channel-agent-experience.md#consult-with-microsoft-teams-users)  
