using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SyncVoiceLibraryDtoProvidersItem>))]
public enum SyncVoiceLibraryDtoProvidersItem
{
    [EnumMember(Value = "11labs")]
    ElevenLabs,

    [EnumMember(Value = "azure")]
    Azure,

    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "custom-voice")]
    CustomVoice,

    [EnumMember(Value = "deepgram")]
    Deepgram,

    [EnumMember(Value = "lmnt")]
    Lmnt,

    [EnumMember(Value = "neets")]
    Neets,

    [EnumMember(Value = "neuphonic")]
    Neuphonic,

    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "playht")]
    Playht,

    [EnumMember(Value = "rime-ai")]
    RimeAi,

    [EnumMember(Value = "smallest-ai")]
    SmallestAi,

    [EnumMember(Value = "tavus")]
    Tavus,
}
