using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<HookOn>))]
public enum HookOn
{
    [EnumMember(Value = "task.start")]
    TaskStart,

    [EnumMember(Value = "task.output.confirmation")]
    TaskOutputConfirmation,

    [EnumMember(Value = "task.delayed")]
    TaskDelayed,
}
