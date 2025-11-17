using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterStringArrayTypeColumnOnCallTableOperator>))]
public enum FilterStringArrayTypeColumnOnCallTableOperator
{
    [EnumMember(Value = "in")]
    In,

    [EnumMember(Value = "not_in")]
    NotIn,
}
