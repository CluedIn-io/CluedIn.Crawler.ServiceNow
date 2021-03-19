using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.ServiceNow.Core;
using CluedIn.Crawling.ServiceNow.Infrastructure.Factories;

namespace CluedIn.Crawling.ServiceNow
{
    public class ServiceNowCrawler : ICrawlerDataGenerator
    {
        private readonly IServiceNowClientFactory clientFactory;
        public ServiceNowCrawler(IServiceNowClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is ServiceNowCrawlJobData servicenowcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(servicenowcrawlJobData);

            foreach(var windows in client.GetIncidents())
            {
                yield return windows;
            }
        }       
    }
}
