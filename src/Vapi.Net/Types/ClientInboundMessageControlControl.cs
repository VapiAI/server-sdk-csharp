using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientInboundMessageControlControlSerializer))]
public enum ClientInboundMessageControlControl
{
    [EnumMember(Value = "mute-assistant")]
    MuteAssistant,

    [EnumMember(Value = "unmute-assistant")]
    UnmuteAssistant,

    [EnumMember(Value = "mute-customer")]
    MuteCustomer,

    [EnumMember(Value = "unmute-customer")]
    UnmuteCustomer,

    [EnumMember(Value = "say-first-message")]
    SayFirstMessage,
}

internal class ClientInboundMessageControlControlSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientInboundMessageControlControl>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientInboundMessageControlControl
    > _stringToEnum = new()
    {
        { "mute-assistant", ClientInboundMessageControlControl.MuteAssistant },
        { "unmute-assistant", ClientInboundMessageControlControl.UnmuteAssistant },
        { "mute-customer", ClientInboundMessageControlControl.MuteCustomer },
        { "unmute-customer", ClientInboundMessageControlControl.UnmuteCustomer },
        { "say-first-message", ClientInboundMessageControlControl.SayFirstMessage },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientInboundMessageControlControl,
        string
    > _enumToString = new()
    {
        { ClientInboundMessageControlControl.MuteAssistant, "mute-assistant" },
        { ClientInboundMessageControlControl.UnmuteAssistant, "unmute-assistant" },
        { ClientInboundMessageControlControl.MuteCustomer, "mute-customer" },
        { ClientInboundMessageControlControl.UnmuteCustomer, "unmute-customer" },
        { ClientInboundMessageControlControl.SayFirstMessage, "say-first-message" },
    };

    public override ClientInboundMessageControlControl Read(
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
        ClientInboundMessageControlControl value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientInboundMessageControlControl ReadAsPropertyName(
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
        ClientInboundMessageControlControl value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
