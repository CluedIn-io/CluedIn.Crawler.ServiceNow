using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.ServiceNow.Core.Models
{

    public class OpenedBy
    {

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SysDomain
    {

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CallerId
    {

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Incident
    {

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("made_sla")]
        public string MadeSla { get; set; }

        [JsonProperty("caused_by")]
        public string CausedBy { get; set; }

        [JsonProperty("watch_list")]
        public string WatchList { get; set; }

        [JsonProperty("sn_esign_document")]
        public string SnEsignDocument { get; set; }

        [JsonProperty("upon_reject")]
        public string UponReject { get; set; }

        [JsonProperty("sys_updated_on")]
        public string SysUpdatedOn { get; set; }

        [JsonProperty("child_incidents")]
        public string ChildIncidents { get; set; }

        [JsonProperty("hold_reason")]
        public string HoldReason { get; set; }

        [JsonProperty("task_effective_number")]
        public string TaskEffectiveNumber { get; set; }

        [JsonProperty("approval_history")]
        public string ApprovalHistory { get; set; }

        [JsonProperty("skills")]
        public string Skills { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("resolved_by")]
        public string ResolvedBy { get; set; }

        [JsonProperty("sys_updated_by")]
        public string SysUpdatedBy { get; set; }

        [JsonProperty("opened_by")]
        public OpenedBy OpenedBy { get; set; }

        [JsonProperty("user_input")]
        public string UserInput { get; set; }

        [JsonProperty("sys_created_on")]
        public string SysCreatedOn { get; set; }

        [JsonProperty("sys_domain")]
        public SysDomain SysDomain { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("route_reason")]
        public string RouteReason { get; set; }

        [JsonProperty("sys_created_by")]
        public string SysCreatedBy { get; set; }

        [JsonProperty("knowledge")]
        public string Knowledge { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("calendar_stc")]
        public string CalendarStc { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("impact")]
        public string Impact { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("sys_domain_path")]
        public string SysDomainPath { get; set; }

        [JsonProperty("rfc")]
        public string Rfc { get; set; }

        [JsonProperty("time_worked")]
        public string TimeWorked { get; set; }

        [JsonProperty("expected_start")]
        public string ExpectedStart { get; set; }

        [JsonProperty("opened_at")]
        public string OpenedAt { get; set; }

        [JsonProperty("business_duration")]
        public string BusinessDuration { get; set; }

        [JsonProperty("group_list")]
        public string GroupList { get; set; }

        [JsonProperty("work_end")]
        public string WorkEnd { get; set; }

        [JsonProperty("caller_id")]
        public CallerId CallerId { get; set; }

        [JsonProperty("reopened_time")]
        public string ReopenedTime { get; set; }

        [JsonProperty("resolved_at")]
        public string ResolvedAt { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("needs_attention")]
        public string NeedsAttention { get; set; }

        [JsonProperty("universal_request")]
        public string UniversalRequest { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("close_code")]
        public string CloseCode { get; set; }

        [JsonProperty("correlation_display")]
        public string CorrelationDisplay { get; set; }

        [JsonProperty("work_start")]
        public string WorkStart { get; set; }

        [JsonProperty("assignment_group")]
        public string AssignmentGroup { get; set; }

        [JsonProperty("additional_assignee_list")]
        public string AdditionalAssigneeList { get; set; }

        [JsonProperty("business_stc")]
        public string BusinessStc { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("calendar_duration")]
        public string CalendarDuration { get; set; }

        [JsonProperty("close_notes")]
        public string CloseNotes { get; set; }

        [JsonProperty("notify")]
        public string Notify { get; set; }

        [JsonProperty("sys_class_name")]
        public string SysClassName { get; set; }

        [JsonProperty("closed_by")]
        public string ClosedBy { get; set; }

        [JsonProperty("follow_up")]
        public string FollowUp { get; set; }

        [JsonProperty("parent_incident")]
        public string ParentIncident { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("sn_esign_esignature_configuration")]
        public string SnEsignEsignatureConfiguration { get; set; }

        [JsonProperty("reopened_by")]
        public string ReopenedBy { get; set; }

        [JsonProperty("incident_state")]
        public string IncidentState { get; set; }

        [JsonProperty("urgency")]
        public string Urgency { get; set; }

        [JsonProperty("problem_id")]
        public string ProblemId { get; set; }

        [JsonProperty("reassignment_count")]
        public string ReassignmentCount { get; set; }

        [JsonProperty("activity_due")]
        public string ActivityDue { get; set; }

        [JsonProperty("action_status")]
        public string ActionStatus { get; set; }

        [JsonProperty("assigned_to")]
        public string AssignedTo { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("approval")]
        public string Approval { get; set; }

        [JsonProperty("sla_due")]
        public string SlaDue { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("sys_mod_count")]
        public string SysModCount { get; set; }

        [JsonProperty("reopen_count")]
        public string ReopenCount { get; set; }

        [JsonProperty("sys_tags")]
        public string SysTags { get; set; }

        [JsonProperty("escalation")]
        public string Escalation { get; set; }

        [JsonProperty("upon_approval")]
        public string UponApproval { get; set; }

        [JsonProperty("correlation_id")]
        public string CorrelationId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class IncidentResponse
    {

        [JsonProperty("result")]
        public List<Incident> Incidents { get; set; }
    }





}
