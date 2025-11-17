using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallHookModelResponseTimeoutOn>))]
public enum CallHookModelResponseTimeoutOn
{
    [EnumMember(Value = "model.response.timeout")]
    ModelResponseTimeout,
}
