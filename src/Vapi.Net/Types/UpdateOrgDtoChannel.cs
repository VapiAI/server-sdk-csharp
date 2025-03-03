using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateOrgDtoChannel>))]
public enum UpdateOrgDtoChannel
{
    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "weekly")]
    Weekly,
}
