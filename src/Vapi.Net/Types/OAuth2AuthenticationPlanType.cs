using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OAuth2AuthenticationPlanType>))]
public enum OAuth2AuthenticationPlanType
{
    [EnumMember(Value = "oauth2")]
    Oauth2,

    [EnumMember(Value = "aws-sts")]
    AwsSts,
}
