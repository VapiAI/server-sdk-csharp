using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnthropicThinkingConfigType>))]
public enum AnthropicThinkingConfigType
{
    [EnumMember(Value = "enabled")]
    Enabled,
}
