using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterStructuredOutputColumnOnCallTableOperator>))]
public enum FilterStructuredOutputColumnOnCallTableOperator
{
    [EnumMember(Value = "=")]
    EqualTo,

    [EnumMember(Value = "!=")]
    NotEquals,

    [EnumMember(Value = ">")]
    GreaterThan,

    [EnumMember(Value = "<")]
    LessThan,

    [EnumMember(Value = ">=")]
    GreaterThanOrEqualTo,

    [EnumMember(Value = "<=")]
    LessThanOrEqualTo,

    [EnumMember(Value = "in")]
    In,

    [EnumMember(Value = "not_in")]
    NotIn,

    [EnumMember(Value = "contains")]
    Contains,

    [EnumMember(Value = "not_contains")]
    NotContains,
}
