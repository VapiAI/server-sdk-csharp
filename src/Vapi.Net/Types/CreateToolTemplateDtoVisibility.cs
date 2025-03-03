using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateToolTemplateDtoVisibility>))]
public enum CreateToolTemplateDtoVisibility
{
    [EnumMember(Value = "public")]
    Public,

    [EnumMember(Value = "private")]
    Private,
}
