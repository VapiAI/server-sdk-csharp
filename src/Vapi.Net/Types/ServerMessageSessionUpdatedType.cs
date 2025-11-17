using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageSessionUpdatedType>))]
public enum ServerMessageSessionUpdatedType
{
    [EnumMember(Value = "session.updated")]
    SessionUpdated,
}
