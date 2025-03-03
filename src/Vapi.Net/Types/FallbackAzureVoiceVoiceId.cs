using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackAzureVoiceVoiceId>))]
public enum FallbackAzureVoiceVoiceId
{
    [EnumMember(Value = "andrew")]
    Andrew,

    [EnumMember(Value = "brian")]
    Brian,

    [EnumMember(Value = "emma")]
    Emma,
}
