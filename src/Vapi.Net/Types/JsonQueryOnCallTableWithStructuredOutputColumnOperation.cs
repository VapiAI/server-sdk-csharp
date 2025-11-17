using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStructuredOutputColumnOperation>))]
public enum JsonQueryOnCallTableWithStructuredOutputColumnOperation
{
    [EnumMember(Value = "average")]
    Average,

    [EnumMember(Value = "count")]
    Count,

    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,
}
