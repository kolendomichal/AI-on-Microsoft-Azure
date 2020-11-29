# Video Indexer

## Introduction

Azure Video Indexer is a service designed to extract insights and information from media. You are able to identify faces, recognize text, object labels, scene segmentations and much more. You are also able to extract insights from audio clips like: emotion or transcription. Video Indexer uses machine learning algorithm, which can be customized and adjusted to desired preferences.

## Use cases

1. Improve a social media application, to search and filter videos posted by content creators.

1. Detect key phrases in audio or wanted people on security camera feeds by police force.

## How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Enter [Video Indexer Portal](https://www.videoindexer.ai/account/login) and **Sign In**.

1. Expand **Accounts Settings** and copy **AccountId**. It will be needed later.

1. Go to [Video Indexer API Portal](https://api-portal.videoindexer.ai/) and **Sign In** using the account from the first step.

1. Go to the **Products** tab and then select **Authorization**.

1. Select **Product Authorizaion subscription**, which was automatically created for you.

1. Copy **Primary Key**. It will be used in next steps.

1. Set these environment variables using values copied before and set them in your **PowerShell** console.

```PowerShell
$env:VIDEO_INDEXER_ACCOUNT = '<account_id>'
$env:VIDEO_INDEXER_API_KEY = '<api_key>'
$env:VIDEO_INDEXER_LOCATION = '<trial>'
```

1. Install [Visual Studio Code](https://code.visualstudio.com/) and copy project template from [Template](https://docs.microsoft.com/en-us/learn/modules/extract-insights-from-videos-with-video-indexer-service/3-upload-index-videos?pivots=csharp)

### Pricing

- Free tier:
  - up to 10 hours of free indexing to website users
  - up to 40 hours of free indexing to API users
- Standard tier (Additional cost will be charged for content that passes over the limit):
  - Audio/Video Analysis => $0.035 per output minute
  - Encoding
    - Standard => $0.015 per output minute
    - Premium => $0.035 per output minute
  - Streaming
    - Standard => ~$2.15/day
    - Premium =>  ~$4.64/day
