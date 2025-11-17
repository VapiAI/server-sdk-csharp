using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TextContentType>))]
public enum TextContentType
{
    [EnumMember(Value = "text")]
    Text,
}
