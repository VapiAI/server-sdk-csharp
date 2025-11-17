using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ComputerToolWithToolCallName>))]
public enum ComputerToolWithToolCallName
{
    [EnumMember(Value = "computer")]
    Computer,
}
