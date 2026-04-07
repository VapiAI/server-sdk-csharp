using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureSpeechTranscriberSegmentationStrategySerializer))]
public enum AzureSpeechTranscriberSegmentationStrategy
{
    [EnumMember(Value = "Default")]
    Default,

    [EnumMember(Value = "Time")]
    Time,

    [EnumMember(Value = "Semantic")]
    Semantic,
}

internal class AzureSpeechTranscriberSegmentationStrategySerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureSpeechTranscriberSegmentationStrategy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureSpeechTranscriberSegmentationStrategy
    > _stringToEnum = new()
    {
        { "Default", AzureSpeechTranscriberSegmentationStrategy.Default },
        { "Time", AzureSpeechTranscriberSegmentationStrategy.Time },
        { "Semantic", AzureSpeechTranscriberSegmentationStrategy.Semantic },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureSpeechTranscriberSegmentationStrategy,
        string
    > _enumToString = new()
    {
        { AzureSpeechTranscriberSegmentationStrategy.Default, "Default" },
        { AzureSpeechTranscriberSegmentationStrategy.Time, "Time" },
        { AzureSpeechTranscriberSegmentationStrategy.Semantic, "Semantic" },
    };

    public override AzureSpeechTranscriberSegmentationStrategy Read(
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
        AzureSpeechTranscriberSegmentationStrategy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureSpeechTranscriberSegmentationStrategy ReadAsPropertyName(
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
        AzureSpeechTranscriberSegmentationStrategy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
