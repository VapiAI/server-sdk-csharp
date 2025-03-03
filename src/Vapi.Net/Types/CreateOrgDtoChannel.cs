using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateOrgDtoChannel>))]
public enum CreateOrgDtoChannel
{
    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "weekly")]
    Weekly,
}
