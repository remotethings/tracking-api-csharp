# TrackingAPI Example CSharp Client

API for retrieving tracking data and changing settings on LightBug & RemoteThings tracking devices

## Getting Started

Open and run tracking-example/tracking-example.sln
Includes Push messaging implementation using MQTT:
- See tracking-example/Messaging.cs and insert your custom code in processNewDatapoint and processNewSensorReading

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

See lib/README.md

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

See Program.login()

## Setup SQS

See Program.cs
```
NotificationTrigger setupSqsPush(Decimal deviceId)
```

You will need to have setup an SQS queue on your account with the following Policy Document:
NOTE: replace  
```
arn:aws:sqs:us-east-2:829297355604:test_lb
```
with your queue ARN in the policy document AND the code
```
{
    "Version": "2012-10-17",
    "Id": "AllowLightbugPush",
    "Statement": [
     {
        "Sid": "AllowLightbugPush001",
        "Effect": "Allow",
        "Principal": "*",
        "Action": "sqs:SendMessage",
        "Resource": "arn:aws:sqs:us-east-2:829297355604:test_lb",
        "Condition": {
            "ArnEquals": {
                "aws:SourceArn": "arn:aws:sns:*:367158939173:*"
            }
        }
     }
    ]
}
```
Based on information available https://docs.aws.amazon.com/sns/latest/dg/SendMessageToSQS.cross.account.html
Once you have run this script, you will need to wait for "SubscriptionConfirmation" message and
visit the SubscribeURL to confirm subscription, as detailed in the above link under *To confirm a subscription using the Amazon SQS console*
