using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateToolTemplateDtoType>))]
public enum CreateToolTemplateDtoType
{
    [EnumMember(Value = "tool")]
    Tool,
}
