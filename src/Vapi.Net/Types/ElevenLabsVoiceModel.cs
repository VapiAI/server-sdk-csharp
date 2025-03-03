using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ElevenLabsVoiceModel>))]
public enum ElevenLabsVoiceModel
{
    [EnumMember(Value = "eleven_multilingual_v2")]
    ElevenMultilingualV2,

    [EnumMember(Value = "eleven_turbo_v2")]
    ElevenTurboV2,

    [EnumMember(Value = "eleven_turbo_v2_5")]
    ElevenTurboV25,

    [EnumMember(Value = "eleven_flash_v2")]
    ElevenFlashV2,

    [EnumMember(Value = "eleven_flash_v2_5")]
    ElevenFlashV25,

    [EnumMember(Value = "eleven_monolingual_v1")]
    ElevenMonolingualV1,
}
