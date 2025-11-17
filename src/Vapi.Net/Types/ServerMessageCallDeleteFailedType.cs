using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageCallDeleteFailedType>))]
public enum ServerMessageCallDeleteFailedType
{
    [EnumMember(Value = "call.delete.failed")]
    CallDeleteFailed,
}
