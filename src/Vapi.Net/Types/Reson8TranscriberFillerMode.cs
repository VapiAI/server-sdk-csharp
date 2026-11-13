using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(Reson8TranscriberFillerModeSerializer))]
public enum Reson8TranscriberFillerMode
{
    [EnumMember(Value = "clean")]
    Clean,

    [EnumMember(Value = "natural")]
    Natural,

    [EnumMember(Value = "verbatim")]
    Verbatim,
}

internal class Reson8TranscriberFillerModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<Reson8TranscriberFillerMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        Reson8TranscriberFillerMode
    > _stringToEnum = new()
    {
        { "clean", Reson8TranscriberFillerMode.Clean },
        { "natural", Reson8TranscriberFillerMode.Natural },
        { "verbatim", Reson8TranscriberFillerMode.Verbatim },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        Reson8TranscriberFillerMode,
        string
    > _enumToString = new()
    {
        { Reson8TranscriberFillerMode.Clean, "clean" },
        { Reson8TranscriberFillerMode.Natural, "natural" },
        { Reson8TranscriberFillerMode.Verbatim, "verbatim" },
    };

    public override Reson8TranscriberFillerMode Read(
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
        Reson8TranscriberFillerMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override Reson8TranscriberFillerMode ReadAsPropertyName(
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
        Reson8TranscriberFillerMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
