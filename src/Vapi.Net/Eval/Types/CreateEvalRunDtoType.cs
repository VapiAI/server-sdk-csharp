using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateEvalRunDtoType>))]
public enum CreateEvalRunDtoType
{
    [EnumMember(Value = "eval")]
    Eval,
}
