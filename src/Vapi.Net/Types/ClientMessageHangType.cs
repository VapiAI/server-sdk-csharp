using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageHangType>))]
public enum ClientMessageHangType
{
    [EnumMember(Value = "hang")]
    Hang,
}
