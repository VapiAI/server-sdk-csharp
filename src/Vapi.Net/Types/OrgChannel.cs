using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OrgChannel>))]
public enum OrgChannel
{
    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "weekly")]
    Weekly,
}
