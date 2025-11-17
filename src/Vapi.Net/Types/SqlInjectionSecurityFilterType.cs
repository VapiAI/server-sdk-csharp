using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SqlInjectionSecurityFilterType>))]
public enum SqlInjectionSecurityFilterType
{
    [EnumMember(Value = "sql-injection")]
    SqlInjection,
}
