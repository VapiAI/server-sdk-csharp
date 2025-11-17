using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiFunctionParametersType>))]
public enum OpenAiFunctionParametersType
{
    [EnumMember(Value = "object")]
    Object,
}
