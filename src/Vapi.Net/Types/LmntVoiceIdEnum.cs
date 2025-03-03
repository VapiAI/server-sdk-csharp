using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LmntVoiceIdEnum>))]
public enum LmntVoiceIdEnum
{
    [EnumMember(Value = "lily")]
    Lily,

    [EnumMember(Value = "daniel")]
    Daniel,
}
