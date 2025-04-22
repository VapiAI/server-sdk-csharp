using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<DeepgramVoiceModel>))]
public enum DeepgramVoiceModel
{
    [EnumMember(Value = "aura")]
    Aura,

    [EnumMember(Value = "aura-2")]
    Aura2,
}
