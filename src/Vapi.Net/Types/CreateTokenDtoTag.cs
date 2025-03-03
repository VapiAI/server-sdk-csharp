using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateTokenDtoTag>))]
public enum CreateTokenDtoTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}
