using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<BashToolWithToolCallName>))]
public enum BashToolWithToolCallName
{
    [EnumMember(Value = "bash")]
    Bash,
}
