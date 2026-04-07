using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferDestinationAssistantTypeSerializer))]
public enum TransferDestinationAssistantType
{
    [EnumMember(Value = "assistant")]
    Assistant,
}

internal class TransferDestinationAssistantTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferDestinationAssistantType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferDestinationAssistantType
    > _stringToEnum = new() { { "assistant", TransferDestinationAssistantType.Assistant } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferDestinationAssistantType,
        string
    > _enumToString = new() { { TransferDestinationAssistantType.Assistant, "assistant" } };

    public override TransferDestinationAssistantType Read(
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
        TransferDestinationAssistantType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferDestinationAssistantType ReadAsPropertyName(
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
        TransferDestinationAssistantType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
