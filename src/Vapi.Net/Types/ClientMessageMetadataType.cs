using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageMetadataTypeSerializer))]
public enum ClientMessageMetadataType
{
    [EnumMember(Value = "metadata")]
    Metadata,
}

internal class ClientMessageMetadataTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageMetadataType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageMetadataType
    > _stringToEnum = new() { { "metadata", ClientMessageMetadataType.Metadata } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageMetadataType,
        string
    > _enumToString = new() { { ClientMessageMetadataType.Metadata, "metadata" } };

    public override ClientMessageMetadataType Read(
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
        ClientMessageMetadataType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageMetadataType ReadAsPropertyName(
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
        ClientMessageMetadataType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
