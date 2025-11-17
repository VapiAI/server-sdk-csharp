using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ComputerToolName>))]
public enum ComputerToolName
{
    [EnumMember(Value = "computer")]
    Computer,
}
