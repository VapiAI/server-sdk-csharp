using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStringTypeColumnTable>))]
public enum JsonQueryOnCallTableWithStringTypeColumnTable
{
    [EnumMember(Value = "call")]
    Call,
}
