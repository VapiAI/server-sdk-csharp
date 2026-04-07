using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMinimaxVoiceRegionSerializer))]
public enum FallbackMinimaxVoiceRegion
{
    [EnumMember(Value = "worldwide")]
    Worldwide,

    [EnumMember(Value = "china")]
    China,
}

internal class FallbackMinimaxVoiceRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMinimaxVoiceRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMinimaxVoiceRegion
    > _stringToEnum = new()
    {
        { "worldwide", FallbackMinimaxVoiceRegion.Worldwide },
        { "china", FallbackMinimaxVoiceRegion.China },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMinimaxVoiceRegion,
        string
    > _enumToString = new()
    {
        { FallbackMinimaxVoiceRegion.Worldwide, "worldwide" },
        { FallbackMinimaxVoiceRegion.China, "china" },
    };

    public override FallbackMinimaxVoiceRegion Read(
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
        FallbackMinimaxVoiceRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMinimaxVoiceRegion ReadAsPropertyName(
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
        FallbackMinimaxVoiceRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
