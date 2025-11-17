using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<InsightType>))]
public enum InsightType
{
    [EnumMember(Value = "bar")]
    Bar,

    [EnumMember(Value = "line")]
    Line,

    [EnumMember(Value = "pie")]
    Pie,

    [EnumMember(Value = "text")]
    Text,
}
