using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.ServiceNow.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.ServiceNow.Unit.Test.ServiceNowProvider
{
    public abstract class ServiceNowProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IServiceNowClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected ServiceNowProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IServiceNowClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new ServiceNow.ServiceNowProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
