using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageSessionUpdatedType>))]
public enum ClientMessageSessionUpdatedType
{
    [EnumMember(Value = "session.updated")]
    SessionUpdated,
}
