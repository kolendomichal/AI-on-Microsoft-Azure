# Azure Cognitive Language Services

Azure Cognitive Language Services provide a set of tools, which
can be used to analyze text, detect vulgar languange / adult themes and process natural language input (in many languages)

## Azure Content Moderator

### Introduction

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

1. We are running a streaming service with embedded live-chat. We can use Azure Content Moderator to filter any profane language that users are sending.
2. Company is dealing with customers private data. Content Moderator can be used to detect if any **PII** information is being sent to email's outside of the organisation.
3. Government and industrial chatbots - use content moderator to filter any sexually explicit/adult themed/offensive language.

### How to

Prerequisities:

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

Language Understanding, in short term **LUIS** , is a tool uses machine-learning to predict the user's input overall meaning
and pull out relevant information.

**LUTS** makes use of three key aspects for understanding the language input:

- Utterances: An utterance is an input from the user that your application need to interpret.
- Intents: An intent (task or action) the user wants to achieve. It's a purpose or a goal which is expressed in a user's utterance.
- Entities: An entity represents a phrase inside the utterance that you want to extract and do some action on.

The result gives you a score from 0 to 1. Score closer to 1, the bigger probability of intent compatibility.

Example:
You have created a bot for finding data about motorcycles. A use may use the following utterance: "Find the maximum speed of Kawasaki H2R".
If we evaluate and extract key aspects of this utterance, we can determine the user's intent. The user wants to find maximum speed of Kawasaki H2R.

In the sample provided earlier we can identify entities like:

- Kawasaki: We can classify this as brand.
- H2R: We can classify this as a model.
- speed: we can classify this as technical data.

### Use Case

1. We have a University chatbot for new students. Student may ask for a location of a department. Using LUIS we can extract key words such as "faculty office" "Department of Computer science".
2. Government chatbot, which thanks to LUIS can connect to the desired consultant.
3. Repair-service chatbot which can give a preliminary diagnosis, basing on key words.

### How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

1. Create your resource and select desired pricing tiers. Student
2. From **Keys** section in left panel, copy one of the two keys shown there.
3. Azure requires you to create the LUIS app in the same geographic location where you created your service. Select one of the URLs for your location:
   - [North America](https://www.luis.ai/)
   - [Europe](https://eu.luis.ai/)
   - [Australia](https://au.luis.ai/)
4. Create an app and select appropriate **Culture**.
5. Create __intent__ and assign 5 example values.
6. Create __entity__, name the entity faced and select __Machine learned__ for __Entity type__.
7. Train the LUIS model.
8. Create a public endpoint for the LUIS service
9. Test your endpoint by providing a sentence.

Example of LUIS response:

```JSON
{
  "query": "when do you open next?",
  "topScoringIntent": {
    "intent": "GetStoreInfo",
    "score": 0.984749258
  },
  "intents": [
    {
      "intent": "GetStoreInfo",
      "score": 0.984749258
    },
    {
      "intent": "None",
      "score": 0.2040639
    }
  ],
  "entities": []
```

There are two pricing configurations you can choose from:

- F0 tier:
  - 5 transactions per second.
    - Text requests:  Up to 10000 free transactions per month.
- S0 tier:
  - 50 transactions per second.
    - Text requests:
      - €1,265 for 1000 transactions
    - Voice requests:
      - €4,639 for 1000 transactions


## Azure Text Analytics

### Introduction

### Use Case

### Usage
