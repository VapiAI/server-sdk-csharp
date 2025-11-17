using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageVoiceInputType>))]
public enum ServerMessageVoiceInputType
{
    [EnumMember(Value = "voice-input")]
    VoiceInput,
}
