using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CampaignControllerFindAllPaginatedRequestStatus>))]
public enum CampaignControllerFindAllPaginatedRequestStatus
{
    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "ended")]
    Ended,
}
