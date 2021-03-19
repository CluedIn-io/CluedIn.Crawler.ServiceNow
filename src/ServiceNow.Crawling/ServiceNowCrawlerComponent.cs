using CluedIn.Core;
using CluedIn.Crawling.ServiceNow.Core;

using ComponentHost;

namespace CluedIn.Crawling.ServiceNow
{
    [Component(ServiceNowConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class ServiceNowCrawlerComponent : CrawlerComponentBase
    {
        public ServiceNowCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

