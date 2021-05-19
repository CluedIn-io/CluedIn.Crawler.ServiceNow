using System.Collections.Generic;
using CluedIn.Core.Crawling;

namespace CluedIn.Crawling.ServiceNow.Core
{
    public class ServiceNowCrawlJobData : CrawlJobData
    {
        public ServiceNowCrawlJobData() { }
        public ServiceNowCrawlJobData(string username, string password, string baseUrl)
        {
            Username = username;
            Password = password;
            BaseUrl = baseUrl;
        }

        public ServiceNowCrawlJobData(IDictionary<string, object> config)
        {
            Username = config["Username"].ToString();
            Password = config["Password"].ToString();
            BaseUrl = config["BaseUrl"].ToString();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string BaseUrl { get; set; }
    }
}
