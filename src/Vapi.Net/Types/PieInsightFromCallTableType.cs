using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PieInsightFromCallTableType>))]
public enum PieInsightFromCallTableType
{
    [EnumMember(Value = "pie")]
    Pie,
}
