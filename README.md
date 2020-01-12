# TwitterDotNetCore

A simple sample app using DotNet Core and the Twitter API.

By default, the code targets the [Twitter Developer Labs](https://t.co.labs) API, requesting @jack's first Tweet (Tweet ID 20). This can be changed by editing the value of `client.RequestUrl` in `Program.cs`.

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
