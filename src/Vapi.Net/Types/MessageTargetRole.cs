using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<MessageTargetRole>))]
public enum MessageTargetRole
{
    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "assistant")]
    Assistant,
}
