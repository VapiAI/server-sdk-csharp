using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiModelPromptCacheRetentionSerializer))]
public enum OpenAiModelPromptCacheRetention
{
    [EnumMember(Value = "in_memory")]
    InMemory,

    [EnumMember(Value = "24h")]
    TwentyFourH,
}

internal class OpenAiModelPromptCacheRetentionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiModelPromptCacheRetention>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiModelPromptCacheRetention
    > _stringToEnum = new()
    {
        { "in_memory", OpenAiModelPromptCacheRetention.InMemory },
        { "24h", OpenAiModelPromptCacheRetention.TwentyFourH },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiModelPromptCacheRetention,
        string
    > _enumToString = new()
    {
        { OpenAiModelPromptCacheRetention.InMemory, "in_memory" },
        { OpenAiModelPromptCacheRetention.TwentyFourH, "24h" },
    };

    public override OpenAiModelPromptCacheRetention Read(
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
        OpenAiModelPromptCacheRetention value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiModelPromptCacheRetention ReadAsPropertyName(
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
        OpenAiModelPromptCacheRetention value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
