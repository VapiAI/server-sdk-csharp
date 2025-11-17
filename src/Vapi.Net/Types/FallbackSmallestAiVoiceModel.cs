using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackSmallestAiVoiceModel>))]
public enum FallbackSmallestAiVoiceModel
{
    [EnumMember(Value = "lightning")]
    Lightning,
}
