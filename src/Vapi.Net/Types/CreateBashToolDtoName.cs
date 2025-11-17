using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateBashToolDtoName>))]
public enum CreateBashToolDtoName
{
    [EnumMember(Value = "bash")]
    Bash,
}
