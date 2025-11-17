using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageSessionDeletedType>))]
public enum ServerMessageSessionDeletedType
{
    [EnumMember(Value = "session.deleted")]
    SessionDeleted,
}
