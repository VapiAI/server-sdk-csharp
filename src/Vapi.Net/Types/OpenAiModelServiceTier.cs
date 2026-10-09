using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiModelServiceTierSerializer))]
public enum OpenAiModelServiceTier
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "priority")]
    Priority,
}

internal class OpenAiModelServiceTierSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiModelServiceTier>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiModelServiceTier
    > _stringToEnum = new()
    {
        { "auto", OpenAiModelServiceTier.Auto },
        { "default", OpenAiModelServiceTier.Default },
        { "fast", OpenAiModelServiceTier.Fast },
        { "priority", OpenAiModelServiceTier.Priority },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiModelServiceTier,
        string
    > _enumToString = new()
    {
        { OpenAiModelServiceTier.Auto, "auto" },
        { OpenAiModelServiceTier.Default, "default" },
        { OpenAiModelServiceTier.Fast, "fast" },
        { OpenAiModelServiceTier.Priority, "priority" },
    };

    public override OpenAiModelServiceTier Read(
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
        OpenAiModelServiceTier value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiModelServiceTier ReadAsPropertyName(
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
        OpenAiModelServiceTier value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
