# Azure Cognitive Speech Services

Azure Cognitive Speech Services provide a set of tools, which can be used to conver audio to text, translating speech or converting text to speech.

## Transcribe speech input to text

### Introduction

Transcribe speech input to text, as title suggests, provides real-time transciption of audio-streams. It is using machine learning and artificial intelligence to convert audio input to text output.

Service is exposed via REST-based APIs or the Speech SDK. They allow developer to integrate those services to any solution.

### Use cases

1. Visiting other country and translating conversation on the fly.
2. Customer service/support. Multi-regional companies can use this service to translate consultant information and customer words back and forth.

### How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Firstly we create the **Speech** resource in our resource group.
2. From **Keys and Endpoints** section in left panel, copy one of the two keys shown there. It will be required to authorize through REST-API or using SDK.
3. Create a C# project, import `Microsoft.CognitiveServices.Speech`. Boilerplate code can be found on [boilerplate](https://docs.microsoft.com/en-us/learn/modules/transcribe-speech-input-text/5-exercise-convert-speech-from-audio-file?pivots=csharp).
   - authorize you program using the copied key
4. Load your .wav file and run the program

If you are not using **SDK**, you can also use REST-API method. Boilerplate code can be found on official [documentation](https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-speech-to-text).

There are two pricing configurations you can choose from:

- F0 tier:
  - **1 concurrent request**
    - 5 audio hours free per month (Speech-to-Text & Speech translation)
- S0 tier:
  - **20 concurrent requests**
    - $1 per audio hour (Speech-to-Text)
    - $2.50 per audio hour (Speech translation)
  
## Synthesize Text Input to Speech

### Introduction

Text-to-Speech service, as name says, synthesizes voice. User can choose from variety of voices to convert text to speech.

Service recognizes text, exact words to be specific, and looks in its database of words and then it is passed to synthesizer to generate spoken words.

### Use cases

1. An application, which recognizes text from the camera and then reads it to the user. That would be heavily beneficial for the blind people. Camera could be installed in their glasses for example.
2. In low-developed countries, it could be used to teach young kids how to pronounce words.

### How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Firstly we create the **Speech** resource in our resource group.
2. From **Keys and Endpoints** section in left panel, copy one of the two keys shown there. It will be required to authorize through REST-API or using SDK.
3. Create a C# project, import `Microsoft.CognitiveServices.Speech`. Boilerplate code can be found on [boilerplate](https://docs.microsoft.com/en-us/learn/modules/synthesize-text-input-speech/3-synthesize-speech-audio-output?pivots=csharp).
   - authorize you program using the copied key
4. Load your text file and run the program

If you are not using **SDK**, you can also use REST-API method. Boilerplate code can be found on official [documentation](https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-text-to-speech).

There are two pricing configurations you can choose from:

- F0 tier:
  - **1 concurrent request**
    - 5 million characters free per month
- S0 tier:
  - **20 concurrent requests**
    - $4 per 1M characters
  
## Translate speech with the speech service

### Introduction

Speech translation service is used for translating spoken phrases in real-time to a selected second language. This service enables people from different countries to communicate easily. 

Using neural network system which was trained on thousands and thousand of hour of incoming audio speech service perform automatic recognition of speech. Model is trained on human-to-human interactions.

### Use cases

1. Meeting of European parliament or any conference where there is a huge mix of ethnic and language groups. Service can translate on the fly the presented/speaker speech.
2. During travelling, normal conversation like shopping or asking for directions could be done with help of that service.

### How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Firstly we create the **Speech** resource in our resource group.
2. From **Keys and Endpoints** section in left panel, copy one of the two keys shown there. It will be required to authorize through REST-API or using SDK.
3. Create a C# project, import `Microsoft.CognitiveServices.Speech`. Boilerplate code can be found on [boilerplate](https://docs.microsoft.com/en-us/learn/modules/translate-speech-speech-service/2-translate-speech-text-microphone-input?pivots=csharp).
   - authorize you program using the copied key
4. Run the program and when the prompt says "Say something", speak an english phrase and then pause.

If you are not using **SDK**, you can also use Speech CLI method..

There are two pricing configurations you can choose from:

- F0 tier:
  - **1 concurrent request**
    - 10 000 free transactions per month (Speaker Verification & Speaker identification)
- S0 tier:
  - **20 concurrent requests**
    - $5 per 1,000 transactions (Speaker Verification)
    - $10 per 1,000 transactions (Speaker identification)