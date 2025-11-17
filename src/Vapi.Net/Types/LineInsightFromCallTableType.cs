using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LineInsightFromCallTableType>))]
public enum LineInsightFromCallTableType
{
    [EnumMember(Value = "line")]
    Line,
}
