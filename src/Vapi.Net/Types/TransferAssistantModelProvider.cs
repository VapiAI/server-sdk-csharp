using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferAssistantModelProvider>))]
public enum TransferAssistantModelProvider
{
    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "anthropic")]
    Anthropic,

    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "custom-llm")]
    CustomLlm,
}
