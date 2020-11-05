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

## Bot Framework Composer

### Introduction

Bot Framework Composer is an azure service which allows user to create an advanced conversational bot without writing code. It uses visual designer to help build complicated mechanism using simple drag & drop.

**Bot Framework Emulator** enables you to:
- use adaptive dialogs for Language Generation
- export created bot to reusable assets in the form of JSON and Markdown files

### Use cases

1. Chatbot for helping new motorcycle drivers decide on begginner motorcycle.
2. TodoList bot for adding new tasks and assignments to your TODOapp (of your choice).
3. Medical chatbot for entry-diagnosis of illnesses

### How to

Prerequisities:

- [.Net Core SKD 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Bot Framework Emulator](https://github.com/microsoft/BotFramework-Emulator/releases/tag/v4.10.0)
- [Bot Framework Composer (windows version)](https://aka.ms/bf-composer-download-win)

1. Start the *Bot Framework Composer* application
2. Select new Bot and select on of the available boilerplates

Watching 5 Minute Intro located in *Bot Framework Composer* dashboard is beneficial before starting working on your bot.

Bot Framework Composer is free, but in order to use Azure Services like *LUIS* or *QnA* you need to have
an active azure subscription and related resources created in a resource group.