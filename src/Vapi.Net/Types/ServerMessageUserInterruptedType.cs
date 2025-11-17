using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageUserInterruptedType>))]
public enum ServerMessageUserInterruptedType
{
    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,
}
