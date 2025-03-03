using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackPlayHtVoiceModel>))]
public enum FallbackPlayHtVoiceModel
{
    [EnumMember(Value = "PlayHT2.0")]
    PlayHt20,

    [EnumMember(Value = "PlayHT2.0-turbo")]
    PlayHt20Turbo,

    [EnumMember(Value = "Play3.0-mini")]
    Play30Mini,

    [EnumMember(Value = "PlayDialog")]
    PlayDialog,
}
