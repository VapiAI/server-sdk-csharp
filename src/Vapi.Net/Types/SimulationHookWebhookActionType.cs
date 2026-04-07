using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationHookWebhookActionTypeSerializer))]
public enum SimulationHookWebhookActionType
{
    [EnumMember(Value = "webhook")]
    Webhook,
}

internal class SimulationHookWebhookActionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationHookWebhookActionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationHookWebhookActionType
    > _stringToEnum = new() { { "webhook", SimulationHookWebhookActionType.Webhook } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationHookWebhookActionType,
        string
    > _enumToString = new() { { SimulationHookWebhookActionType.Webhook, "webhook" } };

    public override SimulationHookWebhookActionType Read(
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
        SimulationHookWebhookActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationHookWebhookActionType ReadAsPropertyName(
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
        SimulationHookWebhookActionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
