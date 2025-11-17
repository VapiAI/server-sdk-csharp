using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TemplateType>))]
public enum TemplateType
{
    [EnumMember(Value = "tool")]
    Tool,
}
