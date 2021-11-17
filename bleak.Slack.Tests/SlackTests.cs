using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace bleak.Slack.Tests
{
    [TestClass]
    public class SlackTests
    {
        //[TestMethod]
        //[Ignore]
        //public void TestPostMessage()
        //{
        //    string urlWithAccessToken = "https://{your_account}.slack.com/services/hooks/incoming-webhook?token={your_access_token}";

        //    SlackClient client = new SlackClient(urlWithAccessToken);

        //    client.PostMessage(username: "@jamalkhan",
        //               text: "This is a test from the Unit Test",
        //               channel: "#general");
        //}

        [TestMethod]
        [Ignore]
        public void TestWebhooks()
        {
            throw new NotImplementedException();
            //Slack.WebHooks.SlackWebhookClient client = new WebHooks.SlackWebhookClient();
            //client.Send();
        }
    }
}