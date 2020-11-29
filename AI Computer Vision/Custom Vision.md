# Custom Vision

## Introduction

Custom Vision is highly versatile tool that enables you to create and train a model, test if for
accuracy and then use it to evaluate and apply labels to images. Through REST-based APIs, it allows custom applications and scripts to integrate this cognitive service directly to your enterprise application.

## Use cases

1. Service company, classify which tool is in need of a repair on basis of the photo provided.

1. Phone application to detect which kind of shroom person encounters in the forest.

1. Phone application to detect what type of tree person is looking at.

## How to

Prerequisities:

- microsoft account
- active subscription on given microsoft account

This is necessary to log in to Azure Portal and start creating your new resource.

1. Enter [Custom Vision Service Portal](https://www.customvision.ai/) and **Sign In**.

1. Select **Create new project** and go through with the process.

1. In the **Artworks** section, add tags, which will be assigned to recognized images.

1. Select **Add images** and select tags, by which those images will be recognized.

1. Click **Train** , to train the model

1. Test the model by clicking **Quick Test** and providing picture which you want to classify.

Now you are able to make requestes and classify images over HTTP.
After selecting **Publish**, you will be provided with dialog of information containing:

- Endpoint Url
- Prediction-Key
- Content-Type
- Example request body

Using these, you will be able to create a request for example from **Postman**.

### Pricing

- Free tier:
  - 20transactions per second
  - features:
    - Upload, training, and prediction transactions
    - Up to 2 projects
    - Up to 1 hour training per month
  - 5,000 training images free per project
  - 10,000 predictions per month
- Standard tier:
  - 10 transactions per second
  - Up to 100 projects
  - features and pricing :
    - Upload and prediction transactions - $2 per 1,000 transactions
    - Training => 1M-5M transactions - $20 per compute hour
    - Image Storage (Up to 6 MB each) => $0.70 per 1,000 images
