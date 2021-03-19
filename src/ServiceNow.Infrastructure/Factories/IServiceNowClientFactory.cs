using CluedIn.Crawling.ServiceNow.Core;

namespace CluedIn.Crawling.ServiceNow.Infrastructure.Factories
{
    public interface IServiceNowClientFactory
    {
        ServiceNowClient2 CreateNew(ServiceNowCrawlJobData servicenowCrawlJobData);
    }
}
