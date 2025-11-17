using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateComputerToolDtoName>))]
public enum UpdateComputerToolDtoName
{
    [EnumMember(Value = "computer")]
    Computer,
}
