using System.IO;
using System.Reflection;
using Castle.MicroKernel.Registration;
using CluedIn.Crawling.ServiceNow.Core;
using CrawlerIntegrationTesting.Clues;
using Xunit.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using DebugCrawlerHost = CrawlerIntegrationTesting.CrawlerHost.DebugCrawlerHost<CluedIn.Crawling.ServiceNow.Core.ServiceNowCrawlJobData>;

namespace CluedIn.Crawling.ServiceNow.Integration.Test
{
    public class ServiceNowTestFixture
    {
        public ClueStorage ClueStorage { get; }
        private readonly DebugCrawlerHost debugCrawlerHost;

        public ILogger<ServiceNowTestFixture> Log { get; }

        public ServiceNowTestFixture()
        {
            var executingFolder = new FileInfo(Assembly.GetExecutingAssembly().CodeBase.Substring(8)).DirectoryName;
            debugCrawlerHost = new DebugCrawlerHost(executingFolder, ServiceNowConstants.ProviderName, c => {
                c.Register(Component.For<ILogger>().UsingFactoryMethod(_ => NullLogger.Instance).LifestyleSingleton());
                c.Register(Component.For<ILoggerFactory>().UsingFactoryMethod(_ => NullLoggerFactory.Instance).LifestyleSingleton());
            });

            ClueStorage = new ClueStorage();

            Log = debugCrawlerHost.AppContext.Container.Resolve<ILogger<ServiceNowTestFixture>>();

            debugCrawlerHost.ProcessClue += ClueStorage.AddClue;

            debugCrawlerHost.Execute(ServiceNowConfiguration.Create(), ServiceNowConstants.ProviderId);
        }

        public void PrintClues(ITestOutputHelper output)
        {
            foreach(var clue in ClueStorage.Clues)
            {
                output.WriteLine(clue.OriginEntityCode.ToString());
            }
        }

        public void PrintLogs(ITestOutputHelper output)
        {
            //TODO:
            //output.WriteLine(Log.PrintLogs());
        }

        public void Dispose()
        {
        }

    }
}


