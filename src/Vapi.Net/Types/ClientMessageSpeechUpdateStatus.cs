using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageSpeechUpdateStatus>))]
public enum ClientMessageSpeechUpdateStatus
{
    [EnumMember(Value = "started")]
    Started,

    [EnumMember(Value = "stopped")]
    Stopped,
}
