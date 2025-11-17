using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ComputerToolSubType>))]
public enum ComputerToolSubType
{
    [EnumMember(Value = "computer_20241022")]
    Computer20241022,
}
