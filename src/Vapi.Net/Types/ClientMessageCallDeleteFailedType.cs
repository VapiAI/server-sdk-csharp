using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageCallDeleteFailedType>))]
public enum ClientMessageCallDeleteFailedType
{
    [EnumMember(Value = "call.delete.failed")]
    CallDeleteFailed,
}
