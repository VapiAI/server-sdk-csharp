using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<McpToolMetadataProtocol>))]
public enum McpToolMetadataProtocol
{
    [EnumMember(Value = "sse")]
    Sse,

    [EnumMember(Value = "shttp")]
    Shttp,
}
