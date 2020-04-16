using System;
using OAuth;
using System.Net;
using System.IO;

namespace TwitterDotNetCore
{

  class Program
  {
    static void Main(string[] args)
    {
      // convenient to load keys and tokens from a config file for testing
      // edit .env.sample (and rename to .env) to add your keys and tokens (no quotation marks)
      DotNetEnv.Env.Load();

      string CONSUMER_KEY = System.Environment.GetEnvironmentVariable("CONSUMER_KEY");
      string CONSUMER_TOKEN = System.Environment.GetEnvironmentVariable("CONSUMER_TOKEN");
      string ACCESS_TOKEN = System.Environment.GetEnvironmentVariable("ACCESS_TOKEN");
      string ACCESS_TOKEN_SECRET = System.Environment.GetEnvironmentVariable("ACCESS_TOKEN_SECRET");

      // this is the endpoint we will be calling
      string REQUEST_URL = "https://api.twitter.com/labs/2/tweets/20?tweet.fields=author_id,created_at,entities,source,public_metrics,lang,geo&expansions=author_id&user.fields=created_at,description,entities,id,location,name,pinned_tweet_id,profile_image_url,protected,url,username,verified,public_metrics";

      // Create a new connection to the OAuth server, with a helper method
      OAuthRequest client = OAuthRequest.ForProtectedResource("GET", CONSUMER_KEY, CONSUMER_TOKEN, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
      client.RequestUrl = REQUEST_URL;

      // add HTTP header authorization
      string auth = client.GetAuthorizationHeader();
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(client.RequestUrl);
      request.Headers.Add("Authorization", auth);

      Console.WriteLine("Calling " + REQUEST_URL);

      // make the call and print the string value of the response JSON
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      Stream dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      string strResponse = reader.ReadToEnd();

      Console.WriteLine(strResponse); // we have a string (JSON)
    }
  }
}
