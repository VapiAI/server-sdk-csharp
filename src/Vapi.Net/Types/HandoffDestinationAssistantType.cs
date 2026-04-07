using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(HandoffDestinationAssistantTypeSerializer))]
public enum HandoffDestinationAssistantType
{
    [EnumMember(Value = "assistant")]
    Assistant,
}

internal class HandoffDestinationAssistantTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<HandoffDestinationAssistantType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        HandoffDestinationAssistantType
    > _stringToEnum = new() { { "assistant", HandoffDestinationAssistantType.Assistant } };

    private static readonly global::System.Collections.Generic.Dictionary<
        HandoffDestinationAssistantType,
        string
    > _enumToString = new() { { HandoffDestinationAssistantType.Assistant, "assistant" } };

    public override HandoffDestinationAssistantType Read(
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
        HandoffDestinationAssistantType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override HandoffDestinationAssistantType ReadAsPropertyName(
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
        HandoffDestinationAssistantType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
