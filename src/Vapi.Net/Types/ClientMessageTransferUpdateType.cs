using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageTransferUpdateTypeSerializer))]
public enum ClientMessageTransferUpdateType
{
    [EnumMember(Value = "transfer-update")]
    TransferUpdate,
}

internal class ClientMessageTransferUpdateTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageTransferUpdateType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageTransferUpdateType
    > _stringToEnum = new()
    {
        { "transfer-update", ClientMessageTransferUpdateType.TransferUpdate },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageTransferUpdateType,
        string
    > _enumToString = new()
    {
        { ClientMessageTransferUpdateType.TransferUpdate, "transfer-update" },
    };

    public override ClientMessageTransferUpdateType Read(
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
        ClientMessageTransferUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageTransferUpdateType ReadAsPropertyName(
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
        ClientMessageTransferUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
