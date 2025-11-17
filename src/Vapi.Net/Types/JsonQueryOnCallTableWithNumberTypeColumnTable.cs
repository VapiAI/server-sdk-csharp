using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithNumberTypeColumnTable>))]
public enum JsonQueryOnCallTableWithNumberTypeColumnTable
{
    [EnumMember(Value = "call")]
    Call,
}
