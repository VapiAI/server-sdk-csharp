using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferModeSerializer))]
public enum TransferMode
{
    [EnumMember(Value = "rolling-history")]
    RollingHistory,

    [EnumMember(Value = "swap-system-message-in-history")]
    SwapSystemMessageInHistory,
}

internal class TransferModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferMode
    > _stringToEnum = new()
    {
        { "rolling-history", TransferMode.RollingHistory },
        { "swap-system-message-in-history", TransferMode.SwapSystemMessageInHistory },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferMode,
        string
    > _enumToString = new()
    {
        { TransferMode.RollingHistory, "rolling-history" },
        { TransferMode.SwapSystemMessageInHistory, "swap-system-message-in-history" },
    };

    public override TransferMode Read(
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
        TransferMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferMode ReadAsPropertyName(
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
        TransferMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
