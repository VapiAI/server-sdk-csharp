using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<EvalModelListOptionsProvider>))]
public enum EvalModelListOptionsProvider
{
    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "anthropic")]
    Anthropic,

    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "groq")]
    Groq,

    [EnumMember(Value = "custom-llm")]
    CustomLlm,
}
