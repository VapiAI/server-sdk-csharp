using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateMakeToolDtoType>))]
public enum CreateMakeToolDtoType
{
    [EnumMember(Value = "make")]
    Make,
}
