using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageSpeechUpdateType>))]
public enum ServerMessageSpeechUpdateType
{
    [EnumMember(Value = "speech-update")]
    SpeechUpdate,
}
