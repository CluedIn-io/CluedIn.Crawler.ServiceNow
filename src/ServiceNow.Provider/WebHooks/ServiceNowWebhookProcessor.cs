using System;
using System.Collections.Generic;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.DataStore;
using CluedIn.Core.Messages.Processing;
using CluedIn.Core.Providers;
using CluedIn.Core.Webhooks;
using CluedIn.Crawling.ServiceNow.ClueProducers;
using CluedIn.Crawling.ServiceNow.Core;
using CluedIn.Crawling.ServiceNow.Core.Models;
using CluedIn.Crawling.ServiceNow.Factories;
using CluedIn.Crawling.ServiceNow.Infrastructure;
using Microsoft.Extensions.Logging;

namespace CluedIn.Provider.ServiceNow.WebHooks
{
    public class ServiceNowWebhookProcessor : BaseWebhookProcessor
    {
        private readonly ILogger<ServiceNowClient2> _log;

        public ServiceNowWebhookProcessor(ILogger<ServiceNowClient2> log, ApplicationContext appContext)
            : base(appContext)
        {
            this._log = log ?? throw new ArgumentNullException(nameof(log));
        }

        public override bool Accept(IWebhookDefinition webhookDefinition)
        {
            return webhookDefinition.ProviderId == ServiceNowConstants.ProviderId || base.Accept(webhookDefinition);
        }

        public override IEnumerable<Clue> DoProcess(ExecutionContext context, WebhookDataCommand command)
        {
            var clues = new List<Clue>();
            try
            {
                var configurationDataStore = context.ApplicationContext.Container.Resolve<IConfigurationRepository>();
                if (command.WebhookDefinition.ProviderDefinitionId != null)
                {
                    var providerDefinition = context.Organization.Providers.GetProviderDefinition(context, command.WebhookDefinition.ProviderDefinitionId.Value);
                    var jobDataCheck = context.ApplicationContext.Container.ResolveAll<IProvider>().FirstOrDefault(providerInstance => providerDefinition != null && providerInstance.Id == providerDefinition.ProviderId);
                    var configStoreData = configurationDataStore.GetConfigurationById(context, command.WebhookDefinition.ProviderDefinitionId.Value);

                    if (providerDefinition?.WebHooks != null)
                        if (providerDefinition.WebHooks == false || providerDefinition.IsEnabled == false)
                            return clues;

                    if (jobDataCheck != null)
                    {
                        var raw = command.HttpPostData;
                        //TODO:Typically the provider (Service Now) will send you the "type"of data it is sending so you can put a switch here to handle the different types of records. 

                        try
                        {
                            var incident = new IncidentClueProducer(new ServiceNowClueFactory(), _log);
                            clues.Add(incident.MakeClue(JsonUtility.Deserialize<Incident>(raw), command.OrganizationId));
                        }
                        catch
                        {
                            _log.LogError("Could not make Incident clue");
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                _log.LogError("Could not process web hook message", exception);
            }

            return clues;
        }
    }
}
