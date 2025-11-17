using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStructuredOutputColumnType>))]
public enum JsonQueryOnCallTableWithStructuredOutputColumnType
{
    [EnumMember(Value = "vapiql-json")]
    VapiqlJson,
}
