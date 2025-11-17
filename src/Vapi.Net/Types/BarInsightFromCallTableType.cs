using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<BarInsightFromCallTableType>))]
public enum BarInsightFromCallTableType
{
    [EnumMember(Value = "bar")]
    Bar,
}
