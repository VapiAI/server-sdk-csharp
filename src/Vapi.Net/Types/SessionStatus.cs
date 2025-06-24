using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SessionStatus>))]
public enum SessionStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "completed")]
    Completed,
}
