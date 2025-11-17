using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallHookCallEndingOn>))]
public enum CallHookCallEndingOn
{
    [EnumMember(Value = "call.ending")]
    CallEnding,
}
