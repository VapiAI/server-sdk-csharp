using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TurnLatencyUnmeasuredItemSerializer))]
public enum TurnLatencyUnmeasuredItem
{
    [EnumMember(Value = "transcriber")]
    Transcriber,

    [EnumMember(Value = "endpointing")]
    Endpointing,

    [EnumMember(Value = "model")]
    Model,

    [EnumMember(Value = "voice")]
    Voice,
}

internal class TurnLatencyUnmeasuredItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TurnLatencyUnmeasuredItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TurnLatencyUnmeasuredItem
    > _stringToEnum = new()
    {
        { "transcriber", TurnLatencyUnmeasuredItem.Transcriber },
        { "endpointing", TurnLatencyUnmeasuredItem.Endpointing },
        { "model", TurnLatencyUnmeasuredItem.Model },
        { "voice", TurnLatencyUnmeasuredItem.Voice },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TurnLatencyUnmeasuredItem,
        string
    > _enumToString = new()
    {
        { TurnLatencyUnmeasuredItem.Transcriber, "transcriber" },
        { TurnLatencyUnmeasuredItem.Endpointing, "endpointing" },
        { TurnLatencyUnmeasuredItem.Model, "model" },
        { TurnLatencyUnmeasuredItem.Voice, "voice" },
    };

    public override TurnLatencyUnmeasuredItem Read(
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
        TurnLatencyUnmeasuredItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TurnLatencyUnmeasuredItem ReadAsPropertyName(
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
        TurnLatencyUnmeasuredItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
