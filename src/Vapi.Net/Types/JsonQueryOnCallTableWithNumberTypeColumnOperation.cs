using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithNumberTypeColumnOperation>))]
public enum JsonQueryOnCallTableWithNumberTypeColumnOperation
{
    [EnumMember(Value = "average")]
    Average,

    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,
}
