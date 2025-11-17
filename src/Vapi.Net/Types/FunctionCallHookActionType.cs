using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FunctionCallHookActionType>))]
public enum FunctionCallHookActionType
{
    [EnumMember(Value = "function")]
    Function,
}
