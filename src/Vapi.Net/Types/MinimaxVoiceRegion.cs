using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MinimaxVoiceRegionSerializer))]
public enum MinimaxVoiceRegion
{
    [EnumMember(Value = "worldwide")]
    Worldwide,

    [EnumMember(Value = "china")]
    China,
}

internal class MinimaxVoiceRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MinimaxVoiceRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MinimaxVoiceRegion
    > _stringToEnum = new()
    {
        { "worldwide", MinimaxVoiceRegion.Worldwide },
        { "china", MinimaxVoiceRegion.China },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MinimaxVoiceRegion,
        string
    > _enumToString = new()
    {
        { MinimaxVoiceRegion.Worldwide, "worldwide" },
        { MinimaxVoiceRegion.China, "china" },
    };

    public override MinimaxVoiceRegion Read(
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
        MinimaxVoiceRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MinimaxVoiceRegion ReadAsPropertyName(
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
        MinimaxVoiceRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
