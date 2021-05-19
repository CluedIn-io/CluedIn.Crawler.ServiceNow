using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Mesh;
using CluedIn.Core.Messages.Processing;
using CluedIn.Core.Messages.WebApp;
using CluedIn.Crawling.ServiceNow.Core;
using RestSharp;
using RestSharp.Authenticators;

namespace CluedIn.Provider.ServiceNow.Mesh
{
    public abstract class ServiceNowDeleteBaseMeshProcessor : BaseMeshProcessor
    {
        public EntityType[] EntityType { get; }
        public string EditUrl { get; }

        protected ServiceNowDeleteBaseMeshProcessor(ApplicationContext appContext, string editUrl, params EntityType[] entityType)
            : base(appContext)
        {
            EntityType = entityType;
            EditUrl = editUrl;
        }

        public override bool Accept(MeshDataCommand command, MeshQuery query, IEntity entity)
        {
            return command.ProviderId == this.GetProviderId() && query.Action == ActionType.REMOVE && EntityType.Contains(entity.EntityType);
        }

        public override void DoProcess(CluedIn.Core.ExecutionContext context, MeshDataCommand command, IDictionary<string, object> jobData, MeshQuery query)
        {
            return;
        }

        public override List<RawQuery> GetRawQueries(IDictionary<string, object> config, IEntity entity, Core.Mesh.Properties properties)
        {
            var serviceNowCrawlJobData = new ServiceNowCrawlJobData(config);

            return new List<Core.Messages.WebApp.RawQuery>()
            {
                new Core.Messages.WebApp.RawQuery()
                {
                    Query = string.Format("curl -X DELETE " + string.Format("{0}/api/now/table/", serviceNowCrawlJobData.BaseUrl) + EditUrl + "--header 'Authorization: Basic {0}' --header \"Content-Type: application/json\"" + " --data '{2}'", serviceNowCrawlJobData.Username, this.GetLookupId(entity), JsonUtility.Serialize(properties)),
                    Source = "cUrl"
                }
            };
        }

        public override Guid GetProviderId()
        {
            return ServiceNowConstants.ProviderId;
        }

        public override string GetVocabularyProviderKey()
        {
            return "serviceNow";
        }

        public override string GetLookupId(IEntity entity)
        {
            var code = entity.Codes.ToList().FirstOrDefault(d => d.Origin.Code == "ServiceNow");
            long id;
            if (!long.TryParse(code.Value, out id))
            {
                //It does not match the id I need.
            }

            return code.Value;
        }

        public override List<QueryResponse> RunQueries(IDictionary<string, object> config, string id, Core.Mesh.Properties properties)
        {
            var serviceNowCrawlJobData = new ServiceNowCrawlJobData(config);
            var client = new RestClient(string.Format("{0}/api/now/table", serviceNowCrawlJobData.BaseUrl));
            var request = new RestRequest(EditUrl, Method.DELETE);
            client.Authenticator = new HttpBasicAuthenticator(serviceNowCrawlJobData.Username, serviceNowCrawlJobData.Password);
                     
            request.AddJsonBody(properties);

            var result = client.ExecuteTaskAsync(request).Result;

            return new List<QueryResponse>() { new QueryResponse() { Content = result.Content, StatusCode = result.StatusCode } };
        }

        public override List<QueryResponse> Validate(ExecutionContext context, MeshDataCommand command, IDictionary<string, object> config, string id, MeshQuery query)
        {
            var serviceNowCrawlJobData = new ServiceNowCrawlJobData(config);
            var client = new RestClient(string.Format("{0}/api/now/table", serviceNowCrawlJobData.BaseUrl));
            var request = new RestRequest(EditUrl, Method.GET);
            client.Authenticator = new HttpBasicAuthenticator(serviceNowCrawlJobData.Username, serviceNowCrawlJobData.Password);

            var result = client.ExecuteTaskAsync(request).Result;

            return new List<QueryResponse>() { new QueryResponse() { Content = result.Content, StatusCode = result.StatusCode } };
        }


    }
}
