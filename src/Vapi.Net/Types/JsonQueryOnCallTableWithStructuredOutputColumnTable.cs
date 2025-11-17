using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStructuredOutputColumnTable>))]
public enum JsonQueryOnCallTableWithStructuredOutputColumnTable
{
    [EnumMember(Value = "call")]
    Call,
}
