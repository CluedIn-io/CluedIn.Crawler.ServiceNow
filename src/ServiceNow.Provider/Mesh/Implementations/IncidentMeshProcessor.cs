using CluedIn.Core;

namespace CluedIn.Provider.ServiceNow.Mesh.Implementations
{
    public class IncidentUpdateMeshProcessor : ServiceNowUpdateBaseMeshProcessor
    {
        public IncidentUpdateMeshProcessor(ApplicationContext appContext)
           : base(appContext, "incident", "/Incident")
        {
        }
    }

    public class IncidentCreateMeshProcessor : ServiceNowCreateBaseMeshProcessor
    {
        public IncidentCreateMeshProcessor(ApplicationContext appContext)
           : base(appContext, "incident", "/Incident")
        {
        }
    }

    public class IncidentDeleteMeshProcessor : ServiceNowDeleteBaseMeshProcessor
    {
        public IncidentDeleteMeshProcessor(ApplicationContext appContext)
           : base(appContext, "incident", "/Incident")
        {
        }
    }
}
