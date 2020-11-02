# Azure Bot Service

## QnA Maker

### Introduction

QnA Maker is an azure service that allows you to create a natural conversation with a user. To put it shortly, it is a more advanced and user-friendly form of FAQ boards.

Service looks for most appropriate answer to any input provided by the user. Answer is based on the custom knowledge base (__KB__) of information. The bigger knowledge base, the better and fluent conversations user can have with our service.

### Use cases

1. Recently introduced "Corona Alert" - polish bot for informing users about covid pandemic in Poland.
2. Chatbot for university students. User can ask questions regarding locations, people or events and bot provides that information basing on its' knowledge base.
3. Bot for people buying their first motorcycle. User can ask questions about what to watch out for when buying motorcycle, cost of specific parts for different models.

### How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Firstly we create the QnA Maker resource in our resource group. Remember to create all of the related resources in the same location.
2. After configuring the options, copy the subscription key - you can find it in **Keys and Endpoints** in the newly created QnA Maker. This subscription key will be used to authorize
in API.
3. Go to [QnA Maker REST API V4.0](https://westus.dev.cognitive.microsoft.com/docs/services/5a93fcf85b4ccd136866eb37/operations/5ac266295b4ccd1554da75ff)
4. Post your knowledge base using POST method and authorize the request using subscription key into **Ocp-Apim-Subscription-Key** box.

You can also log in to [qnamaker.ai](https://www.qnamaker.ai/) and create the knowledge base by directly inserting questions and answers.

There are two pricing configurations you can choose from:

- Free tier:
  - 3 transactions per second
  - features:
    - up to 1MB each document
    - up to 100 transactions per minute
    - up to 50 000 transactions per month
  - 3 managed documents free per month
- Standard tier:
  - 3 transactions per second
  - features:
    - up to 100 transactions per minute
  - $12.80 for unlimited managed documents