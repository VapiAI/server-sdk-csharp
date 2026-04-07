using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaExperimentalControlsSpeedZeroSerializer))]
public enum CartesiaExperimentalControlsSpeedZero
{
    [EnumMember(Value = "slowest")]
    Slowest,

    [EnumMember(Value = "slow")]
    Slow,

    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "fastest")]
    Fastest,
}

internal class CartesiaExperimentalControlsSpeedZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaExperimentalControlsSpeedZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaExperimentalControlsSpeedZero
    > _stringToEnum = new()
    {
        { "slowest", CartesiaExperimentalControlsSpeedZero.Slowest },
        { "slow", CartesiaExperimentalControlsSpeedZero.Slow },
        { "normal", CartesiaExperimentalControlsSpeedZero.Normal },
        { "fast", CartesiaExperimentalControlsSpeedZero.Fast },
        { "fastest", CartesiaExperimentalControlsSpeedZero.Fastest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaExperimentalControlsSpeedZero,
        string
    > _enumToString = new()
    {
        { CartesiaExperimentalControlsSpeedZero.Slowest, "slowest" },
        { CartesiaExperimentalControlsSpeedZero.Slow, "slow" },
        { CartesiaExperimentalControlsSpeedZero.Normal, "normal" },
        { CartesiaExperimentalControlsSpeedZero.Fast, "fast" },
        { CartesiaExperimentalControlsSpeedZero.Fastest, "fastest" },
    };

    public override CartesiaExperimentalControlsSpeedZero Read(
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
        CartesiaExperimentalControlsSpeedZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaExperimentalControlsSpeedZero ReadAsPropertyName(
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
        CartesiaExperimentalControlsSpeedZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
