using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterStringTypeColumnOnCallTableOperator>))]
public enum FilterStringTypeColumnOnCallTableOperator
{
    [EnumMember(Value = "=")]
    EqualTo,

    [EnumMember(Value = "!=")]
    NotEquals,

    [EnumMember(Value = "contains")]
    Contains,

    [EnumMember(Value = "not_contains")]
    NotContains,
}
