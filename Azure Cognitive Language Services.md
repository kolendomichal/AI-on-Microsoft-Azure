# Azure Cognitive Language Services

Azure Cognitive Language Services provide a set of tools, which
can be used to analyze text, detect vulgar languange / adult themes and process natural language input (in many languages)

## Azure Content Moderator

### Intro

Azure Content Moderator is an AI service that enables you handling offensive/unwanted/risky content, that you would like to omit in your application or data.

1. Azure Content Moderator gives you a result, based on the data he has already learned. This result is classified to one of the three categories:

- Category 1 - language that might be considered sexually explicit or adult themed.
- Category 2 - language that might be considered sexually suggestive in certain situations.
- Category 3 - language that might be considered offensive in certain situations.

1. This service can also identify any profane terms you are passing in the text to the API. The profane term is then returned in a JSON resonse, along with data specifiyng where the was used.
An example of JSON response:

```JSON
"Terms": [
{
    "Index": 112,
    "OriginalIndex": 112,
    "ListId": 0,
    "Term": "shit"
}
```

1. Content Moderator is also able to detect Personally identifiable information, also known as **PII**. This might help companies and users detect if there is a leak of private data.
Key aspects that are being detected are:

- Email addresses
- US mailing addresses
- IP addresses
- US phone numbers
- UK phone numbers
- Social Security numbers

### Use cases

w jakich przypadkach powinniśmy użyć tego serwisu - kreatywnie wasze pomysły
    1. We are running a streaming service with embedded live-chat. We can use Azure Content Moderator to filter any profane language that users are sending.
    2. Company is dealing with customers private data. Content Moderator can be used to detect if any **PII** information is being sent to email's outside of the organisation.
    3. Government and industrial chatbots - use content moderator to filter any sexually explicit/adult themed/offensive language.

### How to

In order to use this service, you have to fulfill the minimum criteria:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Firstly we create the said resource in our resource group.
2. After configuring the options, copy the subscription key - you can find it in **Keys and Endpoints** in the newly created Content Moderator. This subscription key will be used to authorize
in API.
3. Then choose the region closest to you from [Content Moderator API Reference page](https://westus.dev.cognitive.microsoft.com/docs/services/57cf753a3f9b070c105bd2c1/operations/57cf753a3f9b070868a1f66f), paste your subscription key into **Ocp-Apim-Subscription-Key** box.

After completing those steps, fill the sample text and click Send.

There are two pricing configurations you can choose from:

- F0 tier - 1 transactions per second. Up to 5000 free transactions per month.
- S0 tier - 10 transactions per second. Up to 1 000 000 transactions.
  - €0,844 for 1000 transactions
  - €0,633 for 1000 transactions (1 milion to 5 milion transactions)
  - €0,506 for 1000 transactions (5 milion to 10 milion transactions)
  - €0,338 for 1000 transactions (more than 10 milion)

## Language Understanding (LUIS)  

### Introduction

### Use Case

### Usage

## Azure Text Analytics

### Introduction

### Use Case

### Usage
