using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageUserInterruptedType>))]
public enum ClientMessageUserInterruptedType
{
    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,
}
