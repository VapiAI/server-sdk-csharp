using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateComputerToolDtoSubType>))]
public enum CreateComputerToolDtoSubType
{
    [EnumMember(Value = "computer_20241022")]
    Computer20241022,
}
