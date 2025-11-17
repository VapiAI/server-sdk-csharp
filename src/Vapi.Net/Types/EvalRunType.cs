using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<EvalRunType>))]
public enum EvalRunType
{
    [EnumMember(Value = "eval")]
    Eval,
}
