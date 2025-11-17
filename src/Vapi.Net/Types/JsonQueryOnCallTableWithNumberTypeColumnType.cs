using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithNumberTypeColumnType>))]
public enum JsonQueryOnCallTableWithNumberTypeColumnType
{
    [EnumMember(Value = "vapiql-json")]
    VapiqlJson,
}
