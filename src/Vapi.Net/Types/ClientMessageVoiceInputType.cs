using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageVoiceInputType>))]
public enum ClientMessageVoiceInputType
{
    [EnumMember(Value = "voice-input")]
    VoiceInput,
}
