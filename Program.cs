using System;
using OAuth;
using System.Net;
using System.IO;
using System.Text;

namespace TwitterDotNetCore
{

  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Enter the Tweet ID: ");
      string tweetID = Console.ReadLine(); // no error checking here!

      // convenient to load keys and tokens from a config file for testing
      // edit .env.sample (and rename to .env) to add your keys and tokens (no quotation marks)
      DotNetEnv.Env.Load();

      string CONSUMER_KEY = System.Environment.GetEnvironmentVariable("CONSUMER_KEY");
      string CONSUMER_TOKEN = System.Environment.GetEnvironmentVariable("CONSUMER_TOKEN");
      string ACCESS_TOKEN = System.Environment.GetEnvironmentVariable("ACCESS_TOKEN");
      string ACCESS_TOKEN_SECRET = System.Environment.GetEnvironmentVariable("ACCESS_TOKEN_SECRET");

      // this is the endpoint we will be calling
      StringBuilder apiPath = new StringBuilder("https://api.twitter.com");
      apiPath.Append("/2/tweets");
      apiPath.AppendFormat("?ids={0}", tweetID);
      apiPath.Append("&tweet.fields=attachments,author_id,context_annotations,created_at,entities,geo,id,in_reply_to_user_id,lang,possibly_sensitive,public_metrics,referenced_tweets,source,text,withheld");
      apiPath.Append("&media.fields=duration_ms,height,media_key,preview_image_url,type,url,width");
      apiPath.Append("&expansions=attachments.poll_ids,attachments.media_keys,author_id,geo.place_id,in_reply_to_user_id,referenced_tweets.id");
      apiPath.Append("&poll.fields=duration_minutes,end_datetime,id,options,voting_status");
      apiPath.Append("&place.fields=contained_within,country,country_code,full_name,geo,id,name,place_type");
      apiPath.Append("&user.fields=created_at,description,entities,id,location,name,pinned_tweet_id,profile_image_url,protected,public_metrics,url,username,verified,withheld");
      string REQUEST_URL = apiPath.ToString();

      // if you would like to compare to v1.1 then this alternative REQUEST_URL does that for Tweet ID 20
      // string REQUEST_URL = "https://api.twitter.com/labs/2/tweets/20?tweet.fields=author_id,created_at,entities,source,public_metrics,lang,geo&expansions=author_id&user.fields=created_at,description,entities,id,location,name,pinned_tweet_id,profile_image_url,protected,url,username,verified,public_metrics";

      // Create a new connection to the OAuth server, with a helper method
      OAuthRequest client = OAuthRequest.ForProtectedResource("GET", CONSUMER_KEY, CONSUMER_TOKEN, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
      client.RequestUrl = REQUEST_URL;

      // add HTTP header authorization
      string auth = client.GetAuthorizationHeader();
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(client.RequestUrl);
      request.Headers.Add("Authorization", auth);

      Console.WriteLine("\nCalling " + REQUEST_URL + "\n");

      // make the call and print the string value of the response JSON
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      Stream dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      string strResponse = reader.ReadToEnd();

      Console.WriteLine(strResponse); // we have a string (JSON)
    }
  }
}
