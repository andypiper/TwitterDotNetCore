# TwitterDotNetCore

[![license](https://img.shields.io/badge/License-Apache%202.0-green.svg)](https://github.com/andypiper/TwitterDotNetCore/blob/master/LICENSE) [![v2](https://img.shields.io/endpoint?url=https%3A%2F%2Ftwbadges.glitch.me%2Fbadges%2Fv2)](https://developer.twitter.com/en/docs/twitter-api/early-access) [![Twitter Follow](https://badgen.net/twitter/follow/andypiper)](https://twitter.com/intent/follow?screen_name=andypiper)

A simple sample app using DotNet Core and the new Twitter API.

By default, the code prompts for a Tweet ID and then *fully hydrates* that via the [Twitter API v2](https://developer.twitter.com/en/docs/twitter-api/early-access). You may also enter a comma-separated list of IDs, as the API endpoint will also handle multiple IDs (up to 100).

To have the code request @jack's first Tweet (Tweet ID 20), and the same fields that are returned in API v1.1, comment out the `REQUEST_URL` value in `Program.cs` and uncomment the replacement in the next section.

### What does it mean to 'hydrate a Tweet'?
Hydrating a Tweet means getting all available fields for a Tweet, given a Tweet ID (or a set of Tweet IDs)

## Directions

[Sign up for Twitter API Essential Access](https://developer.twitter.com/en/portal/petition/essential/basic-info), and create a Project and an App. Generate access token and access token secret via the Twitter Developer Dashboard.

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
