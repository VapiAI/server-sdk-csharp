using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TokenTag>))]
public enum TokenTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}
