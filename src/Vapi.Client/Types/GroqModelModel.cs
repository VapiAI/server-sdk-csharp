using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<GroqModelModel>))]
public enum GroqModelModel
{
    [EnumMember(Value = "llama-3.1-405b-reasoning")]
    Llama31405BReasoning,

    [EnumMember(Value = "llama-3.1-70b-versatile")]
    Llama3170BVersatile,

    [EnumMember(Value = "llama-3.1-8b-instant")]
    Llama318BInstant,

    [EnumMember(Value = "mixtral-8x7b-32768")]
    Mixtral8X7B32768,

    [EnumMember(Value = "llama3-8b-8192")]
    Llama38B8192,

    [EnumMember(Value = "llama3-70b-8192")]
    Llama370B8192,

    [EnumMember(Value = "llama3-groq-8b-8192-tool-use-preview")]
    Llama3Groq8B8192ToolUsePreview,

    [EnumMember(Value = "llama3-groq-70b-8192-tool-use-preview")]
    Llama3Groq70B8192ToolUsePreview,

    [EnumMember(Value = "gemma-7b-it")]
    Gemma7BIt,

    [EnumMember(Value = "gemma2-9b-it")]
    Gemma29BIt,
}
