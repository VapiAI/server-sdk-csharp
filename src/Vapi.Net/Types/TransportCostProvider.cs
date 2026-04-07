using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransportCostProviderSerializer))]
public enum TransportCostProvider
{
    [EnumMember(Value = "daily")]
    Daily,

    [EnumMember(Value = "vapi.websocket")]
    VapiWebsocket,

    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "vonage")]
    Vonage,

    [EnumMember(Value = "telnyx")]
    Telnyx,

    [EnumMember(Value = "vapi.sip")]
    VapiSip,
}

internal class TransportCostProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransportCostProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransportCostProvider
    > _stringToEnum = new()
    {
        { "daily", TransportCostProvider.Daily },
        { "vapi.websocket", TransportCostProvider.VapiWebsocket },
        { "twilio", TransportCostProvider.Twilio },
        { "vonage", TransportCostProvider.Vonage },
        { "telnyx", TransportCostProvider.Telnyx },
        { "vapi.sip", TransportCostProvider.VapiSip },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransportCostProvider,
        string
    > _enumToString = new()
    {
        { TransportCostProvider.Daily, "daily" },
        { TransportCostProvider.VapiWebsocket, "vapi.websocket" },
        { TransportCostProvider.Twilio, "twilio" },
        { TransportCostProvider.Vonage, "vonage" },
        { TransportCostProvider.Telnyx, "telnyx" },
        { TransportCostProvider.VapiSip, "vapi.sip" },
    };

    public override TransportCostProvider Read(
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
        TransportCostProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransportCostProvider ReadAsPropertyName(
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
        TransportCostProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
