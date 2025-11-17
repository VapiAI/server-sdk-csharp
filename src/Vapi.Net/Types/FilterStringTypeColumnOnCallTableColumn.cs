using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterStringTypeColumnOnCallTableColumn>))]
public enum FilterStringTypeColumnOnCallTableColumn
{
    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "workflowId")]
    WorkflowId,

    [EnumMember(Value = "squadId")]
    SquadId,

    [EnumMember(Value = "phoneNumberId")]
    PhoneNumberId,

    [EnumMember(Value = "type")]
    Type,

    [EnumMember(Value = "customerNumber")]
    CustomerNumber,

    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "endedReason")]
    EndedReason,

    [EnumMember(Value = "forwardedPhoneNumber")]
    ForwardedPhoneNumber,

    [EnumMember(Value = "campaignId")]
    CampaignId,
}
