using CluedIn.Core.Crawling;

namespace CluedIn.Crawling.ServiceNow.Core
{
    public class ServiceNowCrawlJobData : CrawlJobData
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string BaseUrl { get; set; }
    }
}
