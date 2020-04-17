# TwitterDotNetCore

[![license](https://img.shields.io/badge/License-Apache%202.0-green.svg)](https://github.com/andypiper/TwitterDotNetCore/blob/master/LICENSE) [![Labs v2](https://img.shields.io/static/v1?label=Twitter%20API&message=Developer%20Labs%20v2&color=794BC4&style=flat&logo=Twitter)](https://developer.twitter.com/en/docs/labs/overview/versioning) [![Twitter Follow](https://badgen.net/twitter/follow/andypiper)](https://twitter.com/intent/follow?screen_name=andypiper)

A simple sample app using DotNet Core and the Twitter API.

By default, the code targets the [Twitter Developer Labs](https://t.co/labs) API, requesting @jack's first Tweet (Tweet ID 20), and the same fields that are returned in API v1.1. This can be changed by editing the value of `REQUEST_URL` in `Program.cs`.

## Directions

[Apply for a Twitter Developer Account](https://t.co.apply-for-access), and create an app. Generate access token and access token secret via the Twitter Developer Dashboard.

(optional) If using the [Twitter Developer Labs](https://t.co/labs) endpoint, you'll also need to have access to Labs, and to connect your app to the Tweets and Users endpoints.

Install [DotNet Core](https://dotnet.microsoft.com/download) :-)

Copy `.env.sample` to `.env` and insert consumer keys and access tokens.

```shell
dotnet restore
dotnet run
```

## Dependencies

The goal here is to provide a minimal example, so dependencies have been keep lightweight. The most useful library is `OAuth.DotNetCore`, which greatly simplifies the process of signing the API request. `DotNetEnv` is used to keep keys and tokens out of source control and in a sensible configuration file. NOTE: this is not production code, and you should take appropriate steps to protect your security keys and tokens.

1. [OAuth.DotNetCore](https://github.com/rhargreaves/oauth-dotnetcore)
2. [DotNetEnv](https://github.com/tonerdo/dotnet-env)
