using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageTransferDestinationRequestTypeSerializer))]
public enum ServerMessageTransferDestinationRequestType
{
    [EnumMember(Value = "transfer-destination-request")]
    TransferDestinationRequest,
}

internal class ServerMessageTransferDestinationRequestTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageTransferDestinationRequestType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageTransferDestinationRequestType
    > _stringToEnum = new()
    {
        {
            "transfer-destination-request",
            ServerMessageTransferDestinationRequestType.TransferDestinationRequest
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageTransferDestinationRequestType,
        string
    > _enumToString = new()
    {
        {
            ServerMessageTransferDestinationRequestType.TransferDestinationRequest,
            "transfer-destination-request"
        },
    };

    public override ServerMessageTransferDestinationRequestType Read(
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
        ServerMessageTransferDestinationRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageTransferDestinationRequestType ReadAsPropertyName(
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
        ServerMessageTransferDestinationRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
