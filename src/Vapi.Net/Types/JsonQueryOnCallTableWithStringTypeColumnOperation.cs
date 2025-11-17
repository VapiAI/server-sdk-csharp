using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStringTypeColumnOperation>))]
public enum JsonQueryOnCallTableWithStringTypeColumnOperation
{
    [EnumMember(Value = "count")]
    Count,
}
