using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<HmacAuthenticationPlanAlgorithm>))]
public enum HmacAuthenticationPlanAlgorithm
{
    [EnumMember(Value = "sha256")]
    Sha256,

    [EnumMember(Value = "sha512")]
    Sha512,

    [EnumMember(Value = "sha1")]
    Sha1,
}
