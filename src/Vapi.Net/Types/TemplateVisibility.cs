using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TemplateVisibility>))]
public enum TemplateVisibility
{
    [EnumMember(Value = "public")]
    Public,

    [EnumMember(Value = "private")]
    Private,
}
