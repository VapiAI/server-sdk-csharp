using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAzureSpeechTranscriberSegmentationStrategySerializer))]
public enum FallbackAzureSpeechTranscriberSegmentationStrategy
{
    [EnumMember(Value = "Default")]
    Default,

    [EnumMember(Value = "Time")]
    Time,

    [EnumMember(Value = "Semantic")]
    Semantic,
}

internal class FallbackAzureSpeechTranscriberSegmentationStrategySerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAzureSpeechTranscriberSegmentationStrategy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAzureSpeechTranscriberSegmentationStrategy
    > _stringToEnum = new()
    {
        { "Default", FallbackAzureSpeechTranscriberSegmentationStrategy.Default },
        { "Time", FallbackAzureSpeechTranscriberSegmentationStrategy.Time },
        { "Semantic", FallbackAzureSpeechTranscriberSegmentationStrategy.Semantic },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAzureSpeechTranscriberSegmentationStrategy,
        string
    > _enumToString = new()
    {
        { FallbackAzureSpeechTranscriberSegmentationStrategy.Default, "Default" },
        { FallbackAzureSpeechTranscriberSegmentationStrategy.Time, "Time" },
        { FallbackAzureSpeechTranscriberSegmentationStrategy.Semantic, "Semantic" },
    };

    public override FallbackAzureSpeechTranscriberSegmentationStrategy Read(
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
        FallbackAzureSpeechTranscriberSegmentationStrategy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAzureSpeechTranscriberSegmentationStrategy ReadAsPropertyName(
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
        FallbackAzureSpeechTranscriberSegmentationStrategy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
