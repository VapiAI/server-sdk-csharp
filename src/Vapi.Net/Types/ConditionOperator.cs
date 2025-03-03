using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ConditionOperator>))]
public enum ConditionOperator
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
