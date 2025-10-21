using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<MinimaxVoiceModel>))]
public enum MinimaxVoiceModel
{
    [EnumMember(Value = "speech-02-hd")]
    Speech02Hd,

    [EnumMember(Value = "speech-02-turbo")]
    Speech02Turbo,

    [EnumMember(Value = "speech-2.5-turbo-preview")]
    Speech25TurboPreview,
}
