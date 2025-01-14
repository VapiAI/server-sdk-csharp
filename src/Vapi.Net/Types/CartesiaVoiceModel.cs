using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CartesiaVoiceModel>))]
public enum CartesiaVoiceModel
{
    [EnumMember(Value = "sonic-english")]
    SonicEnglish,

    [EnumMember(Value = "sonic-multilingual")]
    SonicMultilingual,

    [EnumMember(Value = "sonic-preview")]
    SonicPreview,

    [EnumMember(Value = "sonic")]
    Sonic,
}
