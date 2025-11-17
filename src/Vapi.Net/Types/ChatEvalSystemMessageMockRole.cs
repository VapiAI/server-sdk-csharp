using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ChatEvalSystemMessageMockRole>))]
public enum ChatEvalSystemMessageMockRole
{
    [EnumMember(Value = "system")]
    System,
}
