using System;
using System.Net;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.ServiceNow.Core;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Logging;
using ServiceNow.Api;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using RestSharp.Authenticators;
using CluedIn.Crawling.ServiceNow.Core.Models;
using CluedIn.Core;

namespace CluedIn.Crawling.ServiceNow.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class ServiceNowClient2
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger<ServiceNowClient> log;

        private readonly IRestClient client;

        private readonly ServiceNowCrawlJobData _servicenowCrawlJobData;

        public ServiceNowClient2(ILogger<ServiceNowClient> log, ServiceNowCrawlJobData servicenowCrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (servicenowCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(servicenowCrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this._servicenowCrawlJobData = servicenowCrawlJobData;

            // TODO use info from servicenowCrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
        }

        public IEnumerable<Incident> GetIncidents()
        {
            var client = new RestClient(string.Format("{0}/api/now/table", _servicenowCrawlJobData.BaseUrl));
            var request = new RestRequest("incident", Method.GET);
            client.Authenticator = new HttpBasicAuthenticator(_servicenowCrawlJobData.Username, _servicenowCrawlJobData.Password);
            var response = client.Execute(request);
            var content = JsonUtility.Deserialize<IncidentResponse>(response.Content);
            return content.Incidents;
        }
        public AccountInformation GetAccountInformation()
        {
            //TODO - return some unique information about the remote data source
            // that uniquely identifies the account
            return new AccountInformation(_servicenowCrawlJobData.BaseUrl, _servicenowCrawlJobData.BaseUrl);
        }
    }

    [DataContract]
    public class WinServerModel
    {
        [DataMember(Name = "sys_id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
