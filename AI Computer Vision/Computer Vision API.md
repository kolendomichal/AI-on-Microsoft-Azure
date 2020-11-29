# Computer Vision API

## Introduction

Azure Computer Vision API gives a possibility to identify facial details in pictures and even emotions on given face. Computer Vision also gives an opportunity to detect objects, extract insights from objects, text from images and generate high-quality thumbnails.

## Use cases

1. Camera in office doors building which recognize employee by his face. Would make ID cards obsolete.

1. Surveillance cameras throughout the city to recognize wanted man.

1. Recognize customers' emotions while he is buying at the shop.

## How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. In order to create a resource for desired action, in azure portal browse
AI + Machine Learning.
1. Select **Face** resource.
1. Copy and save the values of KEY 1 and ENDPOINT. These will be used when connecting to the API.
1. In the menu group, select Overview. Then copy the value under Endpoint.

Now you are able to make calls and analyze emotions and faces.
You can use this [api_blade](https://westus.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236/console) to create test requests.

### Limits

- Face list: Up to 1,000 distinct faces
- Person group: Up to 10,000 persons
- Person: Up to 248 faces

### Pricing

- Free tier:
  - 20 transactions per minute
  - features:
    - Face Detection
    - Face Verification
    - Face Identification
    - Face Grouping
    - Similar Face Search
  - 3 managed documents free per month
  - 30,000 transactions free per month
- Standard tier:
  - 10 transactions per second
  - features and pricing :
    - Face Detection => 0-1M transactions - $1 per 1,000 transactions
    - Face Verification => 1M-5M transactions - $0.80 per 1,000 transactions
    - Face Identification => 5M-100M transactions - $0.60 per 1,000 transactions
    - Face Grouping, Similar Face Search => 100M+ transactions - $0.40 per 1,000 transactions
    - Face Storage => $0.01 per 1,000 faces per month