using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateBashToolDtoName>))]
public enum UpdateBashToolDtoName
{
    [EnumMember(Value = "bash")]
    Bash,
}
