using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CustomMessageType>))]
public enum CustomMessageType
{
    [EnumMember(Value = "custom-message")]
    CustomMessage,
}
