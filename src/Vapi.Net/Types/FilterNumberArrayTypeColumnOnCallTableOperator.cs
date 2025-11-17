using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterNumberArrayTypeColumnOnCallTableOperator>))]
public enum FilterNumberArrayTypeColumnOnCallTableOperator
{
    [EnumMember(Value = "in")]
    In,

    [EnumMember(Value = "not_in")]
    NotIn,
}
