using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<InworldVoiceModel>))]
public enum InworldVoiceModel
{
    [EnumMember(Value = "inworld-tts-1")]
    InworldTts1,
}
