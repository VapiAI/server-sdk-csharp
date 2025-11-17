using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageVoiceRequestType>))]
public enum ServerMessageVoiceRequestType
{
    [EnumMember(Value = "voice-request")]
    VoiceRequest,
}
