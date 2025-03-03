using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GroqModelModel>))]
public enum GroqModelModel
{
    [EnumMember(Value = "deepseek-r1-distill-llama-70b")]
    DeepseekR1DistillLlama70B,

    [EnumMember(Value = "llama-3.3-70b-versatile")]
    Llama3370BVersatile,

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

    [EnumMember(Value = "gemma2-9b-it")]
    Gemma29BIt,
}
