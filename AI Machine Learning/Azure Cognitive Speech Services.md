# Azure Cognitive Speech Services

Azure Cognitive Speech Services provide a set of tools, which can be used to conver audio to text, translating speech or converting text to speech.

## Transcribe speech input to text

### Introduction

Transcribe speech input to text, as title suggests, provides real-time transciption of audio-streams. It is using machine learning and artificial intelligence to convert audio input to text output.

Service is exposed via REST-based APIs or the Speech SDK. They allow developer to integrate those services to any solution.

### Use cases

1. Visiting other country and translating conversation on the fly.
2. Customer service/support. Multi-regional companies can use this service to translate consultant information and customer request back and forth.

### How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Firstly we create the said resource in our resource group.
2. Create a C# project, import `Microsoft.CognitiveServices.Speech`. Boilerplate code can be found on [boilerplate](https://docs.microsoft.com/en-us/learn/modules/transcribe-speech-input-text/5-exercise-convert-speech-from-audio-file?pivots=csharp).
3. Load your .wav file and run the program

If you are not using **SDK**, you can also use REST-API method. Boilerplate code can be found on official [documentation](https://docs.microsoft.com/pl-pl/azure/cognitive-services/speech-service/rest-speech-to-text).
Here you will have to use your subscription key, which can be found in resource configuration in azure portal.

There are two pricing configurations you can choose from:

- F0 tier:
- **1 concurrent request**
  - 5 audio hours free per month (Speech-to-Text & Speech translation)
  - 5 million characters free per month (Text to Speech)
  - 10 000 free transactions per month (Speaker Verification & Speaker identification)
- S0 tier:
- **20 concurrent requests**
  - $1 per audio hour (Speech-to-Text)
  - $2.50 per audio hour (Speech translation))
  - $4 per 1M characters (Text to Speech)
  - $5 per 1,000 transactions (Speaker Verification)
  - $10 per 1,000 transactions (Speaker identification)
  
## Synthesize Text Input to Speech

### Introduction

### Use cases

### How to


## Translate speech with the speech service

### Introduction

### Use cases

### How to
