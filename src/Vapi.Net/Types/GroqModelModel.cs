using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GroqModelModelSerializer))]
public enum GroqModelModel
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

internal class GroqModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GroqModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GroqModelModel
    > _stringToEnum = new()
    {
        { "openai/gpt-oss-20b", GroqModelModel.OpenaiGptOss20B },
        { "openai/gpt-oss-120b", GroqModelModel.OpenaiGptOss120B },
        { "deepseek-r1-distill-llama-70b", GroqModelModel.DeepseekR1DistillLlama70B },
        { "llama-3.3-70b-versatile", GroqModelModel.Llama3370BVersatile },
        { "llama-3.1-405b-reasoning", GroqModelModel.Llama31405BReasoning },
        { "llama-3.1-8b-instant", GroqModelModel.Llama318BInstant },
        { "llama3-8b-8192", GroqModelModel.Llama38B8192 },
        { "llama3-70b-8192", GroqModelModel.Llama370B8192 },
        { "gemma2-9b-it", GroqModelModel.Gemma29BIt },
        { "moonshotai/kimi-k2-instruct-0905", GroqModelModel.MoonshotaiKimiK2Instruct0905 },
        {
            "meta-llama/llama-4-maverick-17b-128e-instruct",
            GroqModelModel.MetaLlamaLlama4Maverick17B128EInstruct
        },
        {
            "meta-llama/llama-4-scout-17b-16e-instruct",
            GroqModelModel.MetaLlamaLlama4Scout17B16EInstruct
        },
        { "mistral-saba-24b", GroqModelModel.MistralSaba24B },
        { "compound-beta", GroqModelModel.CompoundBeta },
        { "compound-beta-mini", GroqModelModel.CompoundBetaMini },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GroqModelModel,
        string
    > _enumToString = new()
    {
        { GroqModelModel.OpenaiGptOss20B, "openai/gpt-oss-20b" },
        { GroqModelModel.OpenaiGptOss120B, "openai/gpt-oss-120b" },
        { GroqModelModel.DeepseekR1DistillLlama70B, "deepseek-r1-distill-llama-70b" },
        { GroqModelModel.Llama3370BVersatile, "llama-3.3-70b-versatile" },
        { GroqModelModel.Llama31405BReasoning, "llama-3.1-405b-reasoning" },
        { GroqModelModel.Llama318BInstant, "llama-3.1-8b-instant" },
        { GroqModelModel.Llama38B8192, "llama3-8b-8192" },
        { GroqModelModel.Llama370B8192, "llama3-70b-8192" },
        { GroqModelModel.Gemma29BIt, "gemma2-9b-it" },
        { GroqModelModel.MoonshotaiKimiK2Instruct0905, "moonshotai/kimi-k2-instruct-0905" },
        {
            GroqModelModel.MetaLlamaLlama4Maverick17B128EInstruct,
            "meta-llama/llama-4-maverick-17b-128e-instruct"
        },
        {
            GroqModelModel.MetaLlamaLlama4Scout17B16EInstruct,
            "meta-llama/llama-4-scout-17b-16e-instruct"
        },
        { GroqModelModel.MistralSaba24B, "mistral-saba-24b" },
        { GroqModelModel.CompoundBeta, "compound-beta" },
        { GroqModelModel.CompoundBetaMini, "compound-beta-mini" },
    };

    public override GroqModelModel Read(
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
        GroqModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GroqModelModel ReadAsPropertyName(
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
        GroqModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
