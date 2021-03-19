using System.Collections.Generic;
using CluedIn.Crawling.ServiceNow.Core;

namespace CluedIn.Crawling.ServiceNow.Integration.Test
{
  public static class ServiceNowConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { ServiceNowConstants.KeyName.Username, "demo" }
            };
    }
  }
}
