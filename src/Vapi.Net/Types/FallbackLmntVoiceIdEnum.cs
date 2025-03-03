using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackLmntVoiceIdEnum>))]
public enum FallbackLmntVoiceIdEnum
{
    [EnumMember(Value = "lily")]
    Lily,

    [EnumMember(Value = "daniel")]
    Daniel,
}
