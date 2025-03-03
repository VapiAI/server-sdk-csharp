using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallLogPrivilegedLevel>))]
public enum CallLogPrivilegedLevel
{
    [EnumMember(Value = "INFO")]
    Info,

    [EnumMember(Value = "LOG")]
    Log,

    [EnumMember(Value = "WARN")]
    Warn,

    [EnumMember(Value = "ERROR")]
    Error,

    [EnumMember(Value = "CHECKPOINT")]
    Checkpoint,
}
