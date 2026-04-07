using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalGroqModelModelSerializer))]
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

internal class EvalGroqModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalGroqModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalGroqModelModel
    > _stringToEnum = new()
    {
        { "openai/gpt-oss-20b", EvalGroqModelModel.OpenaiGptOss20B },
        { "openai/gpt-oss-120b", EvalGroqModelModel.OpenaiGptOss120B },
        { "deepseek-r1-distill-llama-70b", EvalGroqModelModel.DeepseekR1DistillLlama70B },
        { "llama-3.3-70b-versatile", EvalGroqModelModel.Llama3370BVersatile },
        { "llama-3.1-405b-reasoning", EvalGroqModelModel.Llama31405BReasoning },
        { "llama-3.1-8b-instant", EvalGroqModelModel.Llama318BInstant },
        { "llama3-8b-8192", EvalGroqModelModel.Llama38B8192 },
        { "llama3-70b-8192", EvalGroqModelModel.Llama370B8192 },
        { "gemma2-9b-it", EvalGroqModelModel.Gemma29BIt },
        { "moonshotai/kimi-k2-instruct-0905", EvalGroqModelModel.MoonshotaiKimiK2Instruct0905 },
        {
            "meta-llama/llama-4-maverick-17b-128e-instruct",
            EvalGroqModelModel.MetaLlamaLlama4Maverick17B128EInstruct
        },
        {
            "meta-llama/llama-4-scout-17b-16e-instruct",
            EvalGroqModelModel.MetaLlamaLlama4Scout17B16EInstruct
        },
        { "mistral-saba-24b", EvalGroqModelModel.MistralSaba24B },
        { "compound-beta", EvalGroqModelModel.CompoundBeta },
        { "compound-beta-mini", EvalGroqModelModel.CompoundBetaMini },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalGroqModelModel,
        string
    > _enumToString = new()
    {
        { EvalGroqModelModel.OpenaiGptOss20B, "openai/gpt-oss-20b" },
        { EvalGroqModelModel.OpenaiGptOss120B, "openai/gpt-oss-120b" },
        { EvalGroqModelModel.DeepseekR1DistillLlama70B, "deepseek-r1-distill-llama-70b" },
        { EvalGroqModelModel.Llama3370BVersatile, "llama-3.3-70b-versatile" },
        { EvalGroqModelModel.Llama31405BReasoning, "llama-3.1-405b-reasoning" },
        { EvalGroqModelModel.Llama318BInstant, "llama-3.1-8b-instant" },
        { EvalGroqModelModel.Llama38B8192, "llama3-8b-8192" },
        { EvalGroqModelModel.Llama370B8192, "llama3-70b-8192" },
        { EvalGroqModelModel.Gemma29BIt, "gemma2-9b-it" },
        { EvalGroqModelModel.MoonshotaiKimiK2Instruct0905, "moonshotai/kimi-k2-instruct-0905" },
        {
            EvalGroqModelModel.MetaLlamaLlama4Maverick17B128EInstruct,
            "meta-llama/llama-4-maverick-17b-128e-instruct"
        },
        {
            EvalGroqModelModel.MetaLlamaLlama4Scout17B16EInstruct,
            "meta-llama/llama-4-scout-17b-16e-instruct"
        },
        { EvalGroqModelModel.MistralSaba24B, "mistral-saba-24b" },
        { EvalGroqModelModel.CompoundBeta, "compound-beta" },
        { EvalGroqModelModel.CompoundBetaMini, "compound-beta-mini" },
    };

    public override EvalGroqModelModel Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        EvalGroqModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalGroqModelModel ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        EvalGroqModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
