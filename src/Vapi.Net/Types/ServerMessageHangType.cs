using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageHangType>))]
public enum ServerMessageHangType
{
    [EnumMember(Value = "hang")]
    Hang,
}
