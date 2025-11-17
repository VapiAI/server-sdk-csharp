using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SmallestAiVoiceModel>))]
public enum SmallestAiVoiceModel
{
    [EnumMember(Value = "lightning")]
    Lightning,
}
