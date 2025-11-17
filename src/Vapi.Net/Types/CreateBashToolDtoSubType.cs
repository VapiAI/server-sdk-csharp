using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateBashToolDtoSubType>))]
public enum CreateBashToolDtoSubType
{
    [EnumMember(Value = "bash_20241022")]
    Bash20241022,
}
