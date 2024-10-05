using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<RuleBasedConditionOperator>))]
public enum RuleBasedConditionOperator
{
    [EnumMember(Value = "eq")]
    Eq,

    [EnumMember(Value = "neq")]
    Neq,

    [EnumMember(Value = "gt")]
    Gt,

    [EnumMember(Value = "gte")]
    Gte,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lte")]
    Lte,
}