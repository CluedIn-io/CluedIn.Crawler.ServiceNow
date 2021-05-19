using CluedIn.Core;
using CluedIn.Core.Webhooks;
using CluedIn.Crawling.ServiceNow.Core;

namespace CluedIn.Provider.ServiceNow.WebHooks
{
    public class ServiceNowWebhookPreValidator : BaseWebhookPrevalidator
    {
        public ServiceNowWebhookPreValidator()
            : base(ServiceNowConstants.ProviderId, ServiceNowConstants.ProviderName)
        {
        }

        public override bool Accept(ExecutionContext context, IWebhookDefinition webhookDefinition)
        {
            return true;
        }
    }
}
