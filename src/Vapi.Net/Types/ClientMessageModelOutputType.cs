using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageModelOutputTypeSerializer))]
public enum ClientMessageModelOutputType
{
    [EnumMember(Value = "model-output")]
    ModelOutput,
}

internal class ClientMessageModelOutputTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageModelOutputType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageModelOutputType
    > _stringToEnum = new() { { "model-output", ClientMessageModelOutputType.ModelOutput } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageModelOutputType,
        string
    > _enumToString = new() { { ClientMessageModelOutputType.ModelOutput, "model-output" } };

    public override ClientMessageModelOutputType Read(
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
        ClientMessageModelOutputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageModelOutputType ReadAsPropertyName(
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
        ClientMessageModelOutputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
