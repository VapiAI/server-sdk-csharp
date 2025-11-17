using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageSpeechUpdateType>))]
public enum ClientMessageSpeechUpdateType
{
    [EnumMember(Value = "speech-update")]
    SpeechUpdate,
}
