using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnthropicCredentialProvider>))]
public enum AnthropicCredentialProvider
{
    [EnumMember(Value = "anthropic")]
    Anthropic,
}
