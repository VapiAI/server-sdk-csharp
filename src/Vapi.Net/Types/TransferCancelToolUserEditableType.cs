using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferCancelToolUserEditableTypeSerializer))]
public enum TransferCancelToolUserEditableType
{
    [EnumMember(Value = "transferCancel")]
    TransferCancel,
}

internal class TransferCancelToolUserEditableTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferCancelToolUserEditableType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferCancelToolUserEditableType
    > _stringToEnum = new()
    {
        { "transferCancel", TransferCancelToolUserEditableType.TransferCancel },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferCancelToolUserEditableType,
        string
    > _enumToString = new()
    {
        { TransferCancelToolUserEditableType.TransferCancel, "transferCancel" },
    };

    public override TransferCancelToolUserEditableType Read(
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
        TransferCancelToolUserEditableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferCancelToolUserEditableType ReadAsPropertyName(
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
        TransferCancelToolUserEditableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
