using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageCallDeletedType>))]
public enum ClientMessageCallDeletedType
{
    [EnumMember(Value = "call.deleted")]
    CallDeleted,
}
