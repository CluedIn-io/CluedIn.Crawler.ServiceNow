using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.ServiceNow.Vocabularies
{
    public class IncidentVocabulary : SimpleVocabulary
    {
        public IncidentVocabulary()
        {
            VocabularyName = "Service Now Insight"; // TODO: Set value
            KeyPrefix = "serviceNow.Insight"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Incident"; // TODO: Check value

            AddGroup("Incident Details", group =>
            {
                ActionStatus = group.Add(new VocabularyKey("ActionStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));
                Active = group.Add(new VocabularyKey("Active", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Value"));
                ActivityDue = group.Add(new VocabularyKey("ActivityDue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Stemmed Form"));
                AdditionalAssigneeList = group.Add(new VocabularyKey("AdditionalAssigneeList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Insight Group"));
                Approval = group.Add(new VocabularyKey("Approval", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Topic"));
                ApprovalHistory = group.Add(new VocabularyKey("ApprovalHistory", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Geo Theme"));
                AssignedTo = group.Add(new VocabularyKey("AssignedTo", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Personal Narrative Theme"));
                AssignmentGroup = group.Add(new VocabularyKey("AssignmentGroup", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Coffee RTD Theme"));
                BusinessDuration = group.Add(new VocabularyKey("BusinessDuration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("EmptyTheme"));
                BusinessStc = group.Add(new VocabularyKey("BusinessStc", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Headwind"));
                CalendarDuration = group.Add(new VocabularyKey("CalendarDuration", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));




       
                GroupList = group.Add(new VocabularyKey("GroupList", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                FollowUp = group.Add(new VocabularyKey("FollowUp", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ExpectedStart = group.Add(new VocabularyKey("ExpectedStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Escalation = group.Add(new VocabularyKey("Escalation", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey("DueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CorrelationId = group.Add(new VocabularyKey("CorrelationId", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CorrelationDisplay = group.Add(new VocabularyKey("CorrelationDisplay", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Contract = group.Add(new VocabularyKey("Contract", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ContactType = group.Add(new VocabularyKey("ContactType", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Comments = group.Add(new VocabularyKey("Comments", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ClosedBy = group.Add(new VocabularyKey("ClosedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CloseNotes = group.Add(new VocabularyKey("CloseNotes", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ClosedAt = group.Add(new VocabularyKey("ClosedAt", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CloseCode = group.Add(new VocabularyKey("CloseCode", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ChildIncidents = group.Add(new VocabularyKey("ChildIncidents", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CausedBy = group.Add(new VocabularyKey("CausedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey("Category", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CallerId = group.Add(new VocabularyKey("CallerId", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CalendarStc = group.Add(new VocabularyKey("CalendarStc", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));


                ReopenCount = group.Add(new VocabularyKey("ReopenCount", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ReassignmentCount = group.Add(new VocabularyKey("ReassignmentCount", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ProblemId = group.Add(new VocabularyKey("ProblemId", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey("Priority", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ParentIncident = group.Add(new VocabularyKey("ParentIncident", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Parent = group.Add(new VocabularyKey("Parent", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Order = group.Add(new VocabularyKey("Order", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                OpenedBy = group.Add(new VocabularyKey("OpenedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                OpenedAt = group.Add(new VocabularyKey("OpenedAt", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey("Number", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Notify = group.Add(new VocabularyKey("Notify", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                NeedsAttention = group.Add(new VocabularyKey("NeedsAttention", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                MadeSla = group.Add(new VocabularyKey("MadeSla", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Knowledge = group.Add(new VocabularyKey("Knowledge", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                IncidentState = group.Add(new VocabularyKey("IncidentState", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Impact = group.Add(new VocabularyKey("Impact", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                HoldReason = group.Add(new VocabularyKey("HoldReason", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));






                ReopenedBy = group.Add(new VocabularyKey("ReopenedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ReopenedTime = group.Add(new VocabularyKey("ReopenedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ResolvedAt = group.Add(new VocabularyKey("ResolvedAt", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ResolvedBy = group.Add(new VocabularyKey("ResolvedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Rfc = group.Add(new VocabularyKey("Rfc", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Severity = group.Add(new VocabularyKey("Severity", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ShortDescription = group.Add(new VocabularyKey("ShortDescription", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Skills = group.Add(new VocabularyKey("Skills", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SlaDue = group.Add(new VocabularyKey("SlaDue", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SnEsignDocument = group.Add(new VocabularyKey("SnEsignDocument", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SnEsignEsignatureConfiguration = group.Add(new VocabularyKey("SnEsignEsignatureConfiguration", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Subcategory = group.Add(new VocabularyKey("Subcategory", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysClassName = group.Add(new VocabularyKey("SysClassName", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysCreatedBy = group.Add(new VocabularyKey("SysCreatedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysCreatedOn = group.Add(new VocabularyKey("SysCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysDomain = group.Add(new VocabularyKey("SysDomain", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysDomainPath = group.Add(new VocabularyKey("SysDomainPath", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysId = group.Add(new VocabularyKey("SysId", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysModCount = group.Add(new VocabularyKey("SysModCount", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysTags = group.Add(new VocabularyKey("SysTags", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SysUpdatedBy = group.Add(new VocabularyKey("SysUpdatedBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));





                SysUpdatedOn = group.Add(new VocabularyKey("SysUpdatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                TaskEffectiveNumber = group.Add(new VocabularyKey("TaskEffectiveNumber", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                TimeWorked = group.Add(new VocabularyKey("TimeWorked", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                UniversalRequest = group.Add(new VocabularyKey("UniversalRequest", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                UponApproval = group.Add(new VocabularyKey("UponApproval", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                UponReject = group.Add(new VocabularyKey("UponReject", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Urgency = group.Add(new VocabularyKey("Urgency", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                UserInput = group.Add(new VocabularyKey("UserInput", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                WatchList = group.Add(new VocabularyKey("WatchList", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                WorkEnd = group.Add(new VocabularyKey("WorkEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                WorkStart = group.Add(new VocabularyKey("WorkStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
            });
        }



        public VocabularyKey SysUpdatedOn { get; internal set; }
        public VocabularyKey TaskEffectiveNumber { get; internal set; }
        public VocabularyKey TimeWorked { get; internal set; }
        public VocabularyKey UniversalRequest { get; internal set; }
        public VocabularyKey UponApproval { get; internal set; }
        public VocabularyKey UponReject { get; internal set; }
        public VocabularyKey Urgency { get; internal set; }
        public VocabularyKey UserInput { get; internal set; }
        public VocabularyKey WatchList { get; internal set; }
        public VocabularyKey WorkEnd { get; internal set; }
        public VocabularyKey WorkStart { get; internal set; }


        public VocabularyKey ReopenedBy { get; internal set; }
        public VocabularyKey ReopenedTime { get; internal set; }
        public VocabularyKey ResolvedAt { get; internal set; }
        public VocabularyKey ResolvedBy { get; internal set; }
        public VocabularyKey Rfc { get; internal set; }
        public VocabularyKey RouteReason { get; internal set; }
        public VocabularyKey Severity { get; internal set; }
        public VocabularyKey ShortDescription { get; internal set; }
        public VocabularyKey Skills { get; internal set; }
        public VocabularyKey SlaDue { get; internal set; }
        public VocabularyKey SnEsignDocument { get; internal set; }
        public VocabularyKey SnEsignEsignatureConfiguration { get; internal set; }
        public VocabularyKey State { get; internal set; }
        public VocabularyKey Subcategory { get; internal set; }
        public VocabularyKey SysClassName { get; internal set; }
        public VocabularyKey SysCreatedBy { get; internal set; }
        public VocabularyKey SysCreatedOn { get; internal set; }
        public VocabularyKey SysDomain { get; internal set; }
        public VocabularyKey SysDomainPath { get; internal set; }
        public VocabularyKey SysId { get; internal set; }
        public VocabularyKey SysModCount { get; internal set; }
        public VocabularyKey SysTags { get; internal set; }
        public VocabularyKey SysUpdatedBy { get; internal set; }
       


        public VocabularyKey ActionStatus { get; internal set; }
        public VocabularyKey Active { get; internal set; }
        public VocabularyKey ActivityDue { get; internal set; }
        public VocabularyKey AdditionalAssigneeList { get; internal set; }
        public VocabularyKey Approval { get; internal set; }
        public VocabularyKey ApprovalHistory { get; internal set; }
        public VocabularyKey AssignedTo { get; internal set; }
        public VocabularyKey AssignmentGroup { get; internal set; }
        public VocabularyKey BusinessDuration { get; internal set; }
        public VocabularyKey BusinessStc { get; internal set; }
        public VocabularyKey CalendarDuration { get; internal set; }
        public VocabularyKey CalendarStc { get; internal set; }
        public VocabularyKey CallerId { get; internal set; }
        public VocabularyKey Category { get; internal set; }
        public VocabularyKey CausedBy { get; internal set; }
        public VocabularyKey ChildIncidents { get; internal set; }
        public VocabularyKey CloseCode { get; internal set; }
        public VocabularyKey ClosedAt { get; internal set; }
        public VocabularyKey CloseNotes { get; internal set; }
        public VocabularyKey ClosedBy { get; internal set; }
        public VocabularyKey Comments { get; internal set; }
        public VocabularyKey ContactType { get; internal set; }
        public VocabularyKey Contract { get; internal set; }
        public VocabularyKey CorrelationDisplay { get; internal set; }
        public VocabularyKey CorrelationId { get; internal set; }
        public VocabularyKey Description { get; internal set; }
        public VocabularyKey DueDate { get; internal set; }
        public VocabularyKey Escalation { get; internal set; }
        public VocabularyKey ExpectedStart { get; internal set; }
        public VocabularyKey FollowUp { get; internal set; }
        public VocabularyKey GroupList { get; internal set; }
        public VocabularyKey HoldReason { get; internal set; }
        public VocabularyKey Impact { get; internal set; }
        public VocabularyKey IncidentState { get; internal set; }
        public VocabularyKey Knowledge { get; internal set; }
        public VocabularyKey Location { get; internal set; }
        public VocabularyKey MadeSla { get; internal set; }
        public VocabularyKey NeedsAttention { get; internal set; }
        public VocabularyKey Notify { get; internal set; }
        public VocabularyKey Number { get; internal set; }
        public VocabularyKey OpenedAt { get; internal set; }
        public VocabularyKey OpenedBy { get; internal set; }
        public VocabularyKey Order { get; internal set; }
        public VocabularyKey Parent { get; internal set; }
        public VocabularyKey ParentIncident { get; internal set; }
        public VocabularyKey Priority { get; internal set; }
        public VocabularyKey ProblemId { get; internal set; }
        public VocabularyKey ReassignmentCount { get; internal set; }
        public VocabularyKey ReopenCount { get; internal set; }
       
    }
}
