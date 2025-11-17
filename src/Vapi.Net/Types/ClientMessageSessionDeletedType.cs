using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageSessionDeletedType>))]
public enum ClientMessageSessionDeletedType
{
    [EnumMember(Value = "session.deleted")]
    SessionDeleted,
}
