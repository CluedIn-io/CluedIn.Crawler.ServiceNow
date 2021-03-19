using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.ServiceNow;
using CluedIn.Crawling.ServiceNow.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.ServiceNow.Unit.Test
{
    public class ServiceNowCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public ServiceNowCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IServiceNowClientFactory>();

            _sut = new ServiceNowCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
