using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<BashToolName>))]
public enum BashToolName
{
    [EnumMember(Value = "bash")]
    Bash,
}
