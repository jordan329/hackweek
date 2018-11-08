# AWS Lambda Setup

## Tools Install

```
aws configure
dotnet tool install --global Amazon.Lambda.Tools --version 3.0.1
dotnet new -i Amazon.Lambda.Templates::*
npm install -g serverless
```

---

## Example Project Configuration

* Project Name: __example-api__
* CloudFormation Stack: __example-api-stack__
* S3 Bucket: __mem-tigerhacks__
* Region: __us-east-1__

## Example Dotnet Setup Commands

Create the Project
* ``` dotnet new serverless.AspNetCoreWebAPI -o example-api ```
* Open up in vs code: ``` code example-api/ ```

Publish to AWS
* ``` cd src/example-api/ && dotnet lambda deploy-serverless ```
    * CloudFormation Stack: __example-api-stack__
    * S3 Bucket: __mem-tigerhacks__
    * Region: __us-east-1__