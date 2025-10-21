using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<EvalGroqModelModel>))]
public enum EvalGroqModelModel
{
    [EnumMember(Value = "openai/gpt-oss-20b")]
    OpenaiGptOss20B,

    [EnumMember(Value = "openai/gpt-oss-120b")]
    OpenaiGptOss120B,

    [EnumMember(Value = "deepseek-r1-distill-llama-70b")]
    DeepseekR1DistillLlama70B,

    [EnumMember(Value = "llama-3.3-70b-versatile")]
    Llama3370BVersatile,

    [EnumMember(Value = "llama-3.1-405b-reasoning")]
    Llama31405BReasoning,

    [EnumMember(Value = "llama-3.1-8b-instant")]
    Llama318BInstant,

    [EnumMember(Value = "llama3-8b-8192")]
    Llama38B8192,

    [EnumMember(Value = "llama3-70b-8192")]
    Llama370B8192,

    [EnumMember(Value = "gemma2-9b-it")]
    Gemma29BIt,

    [EnumMember(Value = "moonshotai/kimi-k2-instruct-0905")]
    MoonshotaiKimiK2Instruct0905,

    [EnumMember(Value = "meta-llama/llama-4-maverick-17b-128e-instruct")]
    MetaLlamaLlama4Maverick17B128EInstruct,

    [EnumMember(Value = "meta-llama/llama-4-scout-17b-16e-instruct")]
    MetaLlamaLlama4Scout17B16EInstruct,

    [EnumMember(Value = "mistral-saba-24b")]
    MistralSaba24B,

    [EnumMember(Value = "compound-beta")]
    CompoundBeta,

    [EnumMember(Value = "compound-beta-mini")]
    CompoundBetaMini,
}
