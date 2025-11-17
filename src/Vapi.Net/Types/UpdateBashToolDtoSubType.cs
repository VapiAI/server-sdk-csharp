using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateBashToolDtoSubType>))]
public enum UpdateBashToolDtoSubType
{
    [EnumMember(Value = "bash_20241022")]
    Bash20241022,
}
