using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SecurityFilterPlanMode>))]
public enum SecurityFilterPlanMode
{
    [EnumMember(Value = "sanitize")]
    Sanitize,

    [EnumMember(Value = "reject")]
    Reject,

    [EnumMember(Value = "replace")]
    Replace,
}
