using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ChatEvalToolResponseMessageMockRole>))]
public enum ChatEvalToolResponseMessageMockRole
{
    [EnumMember(Value = "tool")]
    Tool,
}
