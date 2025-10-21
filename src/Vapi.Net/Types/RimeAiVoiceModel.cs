using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<RimeAiVoiceModel>))]
public enum RimeAiVoiceModel
{
    [EnumMember(Value = "arcana")]
    Arcana,

    [EnumMember(Value = "mistv2")]
    Mistv2,

    [EnumMember(Value = "mist")]
    Mist,
}
