# TwitterDotNetCore

[![license](https://img.shields.io/badge/License-Apache%202.0-green.svg)](https://github.com/andypiper/TwitterDotNetCore/blob/master/LICENSE) [![Labs v2](https://img.shields.io/endpoint?url=https%3A%2F%2Ftwbadges.glitch.me%2Fbadges%2Flabs)](https://developer.twitter.com/en/docs/labs/overview/versioning) [![Twitter Follow](https://img.shields.io/twitter/follow/andypiper?label=Follow%20%40andypiper)](https://twitter.com/intent/follow?screen_name=andypiper)

A simple sample app using DotNet Core and the new Twitter API.

By default, the code prompts for a Tweet ID and then *fully hydrates* that via the [Twitter Developer Labs](https://t.co/labs) API. You may also enter a comma-separated list of IDs, as the API endpoint will also handle multiple IDs (up to 100).

To have the code request @jack's first Tweet (Tweet ID 20), and the same fields that are returned in API v1.1, comment out the `REQUEST_URL` value in `Program.cs` and uncomment the replacement in the next section.

### What does it mean to 'hydrate a Tweet'?
Hydrating a Tweet means getting all available fields for a Tweet, given a Tweet ID (or a set of Tweet IDs)

## Directions

[Apply for a Twitter Developer Account](https://t.co.apply-for-access), and create an app. Generate access token and access token secret via the Twitter Developer Dashboard.

(optional) If using the [Twitter Developer Labs](https://t.co/labs) endpoint - as this sample does - you'll also need to have access to Labs, and to connect your app to the Tweets and Users endpoints.

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
