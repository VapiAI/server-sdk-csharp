using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CartesiaVoiceModel>))]
public enum CartesiaVoiceModel
{
    [EnumMember(Value = "sonic-2")]
    Sonic2,

    [EnumMember(Value = "sonic-english")]
    SonicEnglish,

    [EnumMember(Value = "sonic-multilingual")]
    SonicMultilingual,

    [EnumMember(Value = "sonic-preview")]
    SonicPreview,

    [EnumMember(Value = "sonic")]
    Sonic,
}
