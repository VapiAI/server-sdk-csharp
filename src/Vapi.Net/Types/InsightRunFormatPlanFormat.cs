using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<InsightRunFormatPlanFormat>))]
public enum InsightRunFormatPlanFormat
{
    [EnumMember(Value = "raw")]
    Raw,

    [EnumMember(Value = "recharts")]
    Recharts,
}
