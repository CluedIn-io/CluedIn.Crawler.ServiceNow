using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.ServiceNow.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.ServiceNow.Core.Models;
using CluedIn.Crawling.ServiceNow;
using CluedIn.Core.Utilities;
using CluedIn.Crawling.ServiceNow.Infrastructure;
using Microsoft.Extensions.Logging;
using CluedIn.Crawling.Helpers;
using System.Linq;
using CluedIn.Crawling.ServiceNow.Vocabularies;

namespace CluedIn.Crawling.ServiceNow.ClueProducers
{
    public class IncidentClueProducer : BaseClueProducer<Incident>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<ServiceNowClient2> _log;

        public IncidentClueProducer([NotNull] IClueFactory factory, ILogger<ServiceNowClient2> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Incident input, Guid id)
        {
            var clue = _factory.Create("/Incident", input.Number, id);
            var data = clue.Data.EntityData;

            var code = new EntityCode("/Incident", "ServiceNow", input.SysId);
            data.Codes.Add(code);

            var vocab = new IncidentVocabulary();

            if (!string.IsNullOrEmpty(input.ShortDescription))
            {
                data.Name = input.ShortDescription;
            }

            if (!string.IsNullOrEmpty(input.Description))
            {
                data.Description = input.Description;
            }

            DateTimeOffset modifiedDate;
            if (DateTimeOffset.TryParse(input.SysUpdatedOn, out modifiedDate))
            {
                data.ModifiedDate = modifiedDate;
            }

            DateTimeOffset createdDate;
            if (DateTimeOffset.TryParse(input.SysCreatedOn, out createdDate))
            {
                data.CreatedDate = createdDate;
            }

            if (!string.IsNullOrEmpty(input.Category))
            {
                data.Tags.Add(new Tag(input.Category));
            }

            data.Properties[vocab.ActionStatus] = input.ActionStatus.PrintIfAvailable();
            data.Properties[vocab.Active] = input.Active.PrintIfAvailable();
            data.Properties[vocab.ActivityDue] = input.ActivityDue.PrintIfAvailable();
            data.Properties[vocab.AdditionalAssigneeList] = input.AdditionalAssigneeList.PrintIfAvailable();
            data.Properties[vocab.Approval] = input.Approval.PrintIfAvailable();
            data.Properties[vocab.ApprovalHistory] = input.ApprovalHistory.PrintIfAvailable();
            data.Properties[vocab.AssignedTo] = input.AssignedTo.PrintIfAvailable();
            data.Properties[vocab.AssignmentGroup] = input.AssignmentGroup.PrintIfAvailable();
            data.Properties[vocab.BusinessDuration] = input.BusinessDuration.PrintIfAvailable();
            data.Properties[vocab.BusinessStc] = input.BusinessStc.PrintIfAvailable();
            data.Properties[vocab.CalendarDuration] = input.CalendarDuration.PrintIfAvailable();
            data.Properties[vocab.CalendarStc] = input.CalendarStc.PrintIfAvailable();

            //Edge
            data.Properties[vocab.CallerId] = input.CallerId.PrintIfAvailable();
            data.Properties[vocab.Category] = input.Category.PrintIfAvailable();
            data.Properties[vocab.CausedBy] = input.CausedBy.PrintIfAvailable();
            data.Properties[vocab.ChildIncidents] = input.ChildIncidents.PrintIfAvailable();
            data.Properties[vocab.CloseCode] = input.CloseCode.PrintIfAvailable();
            data.Properties[vocab.ClosedAt] = input.ClosedAt.PrintIfAvailable();

            //Edge
            data.Properties[vocab.ClosedBy] = input.ClosedBy.PrintIfAvailable();
            data.Properties[vocab.CloseNotes] = input.CloseNotes.PrintIfAvailable();
            data.Properties[vocab.Comments] = input.Comments.PrintIfAvailable();
            data.Properties[vocab.ContactType] = input.ContactType.PrintIfAvailable();
            data.Properties[vocab.Contract] = input.Contract.PrintIfAvailable();
            data.Properties[vocab.CorrelationDisplay] = input.CorrelationDisplay.PrintIfAvailable();
            data.Properties[vocab.CorrelationId] = input.CorrelationId.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.DueDate] = input.DueDate.PrintIfAvailable();
            data.Properties[vocab.Escalation] = input.Escalation.PrintIfAvailable();
            data.Properties[vocab.ExpectedStart] = input.ExpectedStart.PrintIfAvailable();
            data.Properties[vocab.FollowUp] = input.FollowUp.PrintIfAvailable();
            data.Properties[vocab.GroupList] = input.GroupList.PrintIfAvailable();
            data.Properties[vocab.HoldReason] = input.HoldReason.PrintIfAvailable();
            data.Properties[vocab.Impact] = input.Impact.PrintIfAvailable();
            data.Properties[vocab.IncidentState] = input.IncidentState.PrintIfAvailable();
            data.Properties[vocab.Knowledge] = input.Knowledge.PrintIfAvailable();
            data.Properties[vocab.Location] = input.Location.PrintIfAvailable();
            data.Properties[vocab.MadeSla] = input.MadeSla.PrintIfAvailable();
            data.Properties[vocab.NeedsAttention] = input.NeedsAttention.PrintIfAvailable();
            data.Properties[vocab.Notify] = input.Notify.PrintIfAvailable();
            data.Properties[vocab.Number] = input.Number.PrintIfAvailable();
            data.Properties[vocab.OpenedAt] = input.OpenedAt.PrintIfAvailable();
            data.Properties[vocab.OpenedBy] = input.OpenedBy.PrintIfAvailable();
            data.Properties[vocab.Order] = input.Order.PrintIfAvailable();
            data.Properties[vocab.Parent] = input.Parent.PrintIfAvailable();
            data.Properties[vocab.ParentIncident] = input.ParentIncident.PrintIfAvailable();
            data.Properties[vocab.Priority] = input.Priority.PrintIfAvailable();
            data.Properties[vocab.ProblemId] = input.ProblemId.PrintIfAvailable();
            data.Properties[vocab.ReassignmentCount] = input.ReassignmentCount.PrintIfAvailable();
            data.Properties[vocab.ReopenCount] = input.ReopenCount.PrintIfAvailable();
            data.Properties[vocab.ReopenedBy] = input.ReopenedBy.PrintIfAvailable();
            data.Properties[vocab.ReopenedTime] = input.ReopenedTime.PrintIfAvailable();
            data.Properties[vocab.ResolvedAt] = input.ResolvedAt.PrintIfAvailable();
            data.Properties[vocab.ResolvedBy] = input.ResolvedBy.PrintIfAvailable();
            data.Properties[vocab.Rfc] = input.Rfc.PrintIfAvailable();
            data.Properties[vocab.RouteReason] = input.RouteReason.PrintIfAvailable();
            data.Properties[vocab.Severity] = input.Severity.PrintIfAvailable();
            data.Properties[vocab.ShortDescription] = input.ShortDescription.PrintIfAvailable();
            data.Properties[vocab.Skills] = input.Skills.PrintIfAvailable();
            data.Properties[vocab.SlaDue] = input.SlaDue.PrintIfAvailable();
            data.Properties[vocab.SnEsignDocument] = input.SnEsignDocument.PrintIfAvailable();
            data.Properties[vocab.SnEsignEsignatureConfiguration] = input.SnEsignEsignatureConfiguration.PrintIfAvailable();
            data.Properties[vocab.State] = input.State.PrintIfAvailable();
            data.Properties[vocab.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[vocab.SysClassName] = input.SysClassName.PrintIfAvailable();
            data.Properties[vocab.SysCreatedBy] = input.SysCreatedBy.PrintIfAvailable();
            data.Properties[vocab.SysCreatedOn] = input.SysCreatedOn.PrintIfAvailable();

            //Edge
            data.Properties[vocab.SysDomain] = input.SysDomain.PrintIfAvailable();
            data.Properties[vocab.SysDomainPath] = input.SysDomainPath.PrintIfAvailable();
            data.Properties[vocab.SysId] = input.SysId.PrintIfAvailable();
            data.Properties[vocab.SysModCount] = input.SysModCount.PrintIfAvailable();
            data.Properties[vocab.SysTags] = input.SysTags.PrintIfAvailable();
            data.Properties[vocab.SysUpdatedBy] = input.SysUpdatedBy.PrintIfAvailable();
            data.Properties[vocab.SysUpdatedOn] = input.SysUpdatedOn.PrintIfAvailable();
            data.Properties[vocab.TaskEffectiveNumber] = input.TaskEffectiveNumber.PrintIfAvailable();
            data.Properties[vocab.TimeWorked] = input.TimeWorked.PrintIfAvailable();
            data.Properties[vocab.UniversalRequest] = input.UniversalRequest.PrintIfAvailable();
            data.Properties[vocab.UponApproval] = input.UponApproval.PrintIfAvailable();
            data.Properties[vocab.UponReject] = input.UponReject.PrintIfAvailable();
            data.Properties[vocab.Urgency] = input.Urgency.PrintIfAvailable();
            data.Properties[vocab.UserInput] = input.UserInput.PrintIfAvailable();
            data.Properties[vocab.WatchList] = input.WatchList.PrintIfAvailable();
            data.Properties[vocab.WorkEnd] = input.WorkEnd.PrintIfAvailable();
            data.Properties[vocab.WorkStart] = input.WorkStart.PrintIfAvailable();

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            return clue;
        }
    }
}
