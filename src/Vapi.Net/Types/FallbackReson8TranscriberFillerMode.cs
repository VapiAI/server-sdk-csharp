using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackReson8TranscriberFillerModeSerializer))]
public enum FallbackReson8TranscriberFillerMode
{
    [EnumMember(Value = "clean")]
    Clean,

    [EnumMember(Value = "natural")]
    Natural,

    [EnumMember(Value = "verbatim")]
    Verbatim,
}

internal class FallbackReson8TranscriberFillerModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackReson8TranscriberFillerMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackReson8TranscriberFillerMode
    > _stringToEnum = new()
    {
        { "clean", FallbackReson8TranscriberFillerMode.Clean },
        { "natural", FallbackReson8TranscriberFillerMode.Natural },
        { "verbatim", FallbackReson8TranscriberFillerMode.Verbatim },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackReson8TranscriberFillerMode,
        string
    > _enumToString = new()
    {
        { FallbackReson8TranscriberFillerMode.Clean, "clean" },
        { FallbackReson8TranscriberFillerMode.Natural, "natural" },
        { FallbackReson8TranscriberFillerMode.Verbatim, "verbatim" },
    };

    public override FallbackReson8TranscriberFillerMode Read(
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
        FallbackReson8TranscriberFillerMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackReson8TranscriberFillerMode ReadAsPropertyName(
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
        FallbackReson8TranscriberFillerMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
