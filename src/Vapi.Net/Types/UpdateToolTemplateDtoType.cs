using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateToolTemplateDtoType>))]
public enum UpdateToolTemplateDtoType
{
    [EnumMember(Value = "tool")]
    Tool,
}
