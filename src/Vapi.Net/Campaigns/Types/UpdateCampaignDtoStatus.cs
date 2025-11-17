using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateCampaignDtoStatus>))]
public enum UpdateCampaignDtoStatus
{
    [EnumMember(Value = "ended")]
    Ended,
}
