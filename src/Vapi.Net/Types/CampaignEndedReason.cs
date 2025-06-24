using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CampaignEndedReason>))]
public enum CampaignEndedReason
{
    [EnumMember(Value = "campaign.scheduled.ended-by-user")]
    CampaignScheduledEndedByUser,

    [EnumMember(Value = "campaign.in-progress.ended-by-user")]
    CampaignInProgressEndedByUser,

    [EnumMember(Value = "campaign.ended.success")]
    CampaignEndedSuccess,
}
