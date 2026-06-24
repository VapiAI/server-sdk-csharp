using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaSpeedControlZeroSerializer))]
public enum CartesiaSpeedControlZero
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

internal class CartesiaSpeedControlZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaSpeedControlZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaSpeedControlZero
    > _stringToEnum = new()
    {
        { "slowest", CartesiaSpeedControlZero.Slowest },
        { "slow", CartesiaSpeedControlZero.Slow },
        { "normal", CartesiaSpeedControlZero.Normal },
        { "fast", CartesiaSpeedControlZero.Fast },
        { "fastest", CartesiaSpeedControlZero.Fastest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaSpeedControlZero,
        string
    > _enumToString = new()
    {
        { CartesiaSpeedControlZero.Slowest, "slowest" },
        { CartesiaSpeedControlZero.Slow, "slow" },
        { CartesiaSpeedControlZero.Normal, "normal" },
        { CartesiaSpeedControlZero.Fast, "fast" },
        { CartesiaSpeedControlZero.Fastest, "fastest" },
    };

    public override CartesiaSpeedControlZero Read(
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
        CartesiaSpeedControlZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaSpeedControlZero ReadAsPropertyName(
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
        CartesiaSpeedControlZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
