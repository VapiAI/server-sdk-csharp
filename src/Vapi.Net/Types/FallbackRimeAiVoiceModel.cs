using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackRimeAiVoiceModel>))]
public enum FallbackRimeAiVoiceModel
{
    [EnumMember(Value = "v1")]
    V1,

    [EnumMember(Value = "mist")]
    Mist,
}