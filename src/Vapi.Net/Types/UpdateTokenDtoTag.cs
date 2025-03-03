using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateTokenDtoTag>))]
public enum UpdateTokenDtoTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}
