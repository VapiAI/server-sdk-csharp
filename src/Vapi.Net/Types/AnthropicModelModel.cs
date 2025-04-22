using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnthropicModelModel>))]
public enum AnthropicModelModel
{
    [EnumMember(Value = "claude-3-opus-20240229")]
    Claude3Opus20240229,

    [EnumMember(Value = "claude-3-sonnet-20240229")]
    Claude3Sonnet20240229,

    [EnumMember(Value = "claude-3-haiku-20240307")]
    Claude3Haiku20240307,

    [EnumMember(Value = "claude-3-5-sonnet-20240620")]
    Claude35Sonnet20240620,

    [EnumMember(Value = "claude-3-5-sonnet-20241022")]
    Claude35Sonnet20241022,

    [EnumMember(Value = "claude-3-5-haiku-20241022")]
    Claude35Haiku20241022,

    [EnumMember(Value = "claude-3-7-sonnet-20250219")]
    Claude37Sonnet20250219,
}
