using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackOpenAiVoiceModel>))]
public enum FallbackOpenAiVoiceModel
{
    [EnumMember(Value = "tts-1")]
    Tts1,

    [EnumMember(Value = "tts-1-hd")]
    Tts1Hd,

    [EnumMember(Value = "gpt-4o-mini-tts")]
    Gpt4OMiniTts,
}
