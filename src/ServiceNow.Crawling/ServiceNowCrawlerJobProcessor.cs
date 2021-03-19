using CluedIn.Crawling.ServiceNow.Core;

namespace CluedIn.Crawling.ServiceNow
{
    public class ServiceNowCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<ServiceNowCrawlJobData>
    {
        public ServiceNowCrawlerJobProcessor(ServiceNowCrawlerComponent component) : base(component)
        {
        }
    }
}
