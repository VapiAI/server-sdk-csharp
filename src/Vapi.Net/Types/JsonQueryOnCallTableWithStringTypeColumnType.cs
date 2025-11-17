using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStringTypeColumnType>))]
public enum JsonQueryOnCallTableWithStringTypeColumnType
{
    [EnumMember(Value = "vapiql-json")]
    VapiqlJson,
}
