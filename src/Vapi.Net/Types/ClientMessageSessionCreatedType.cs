using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageSessionCreatedType>))]
public enum ClientMessageSessionCreatedType
{
    [EnumMember(Value = "session.created")]
    SessionCreated,
}
