using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ChatEvalUserMessageMockRole>))]
public enum ChatEvalUserMessageMockRole
{
    [EnumMember(Value = "user")]
    User,
}
