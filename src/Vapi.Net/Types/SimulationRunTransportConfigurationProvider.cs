using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunTransportConfigurationProviderSerializer))]
public enum SimulationRunTransportConfigurationProvider
{
    [EnumMember(Value = "vapi.websocket")]
    VapiWebsocket,

    [EnumMember(Value = "vapi.webchat")]
    VapiWebchat,
}

internal class SimulationRunTransportConfigurationProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunTransportConfigurationProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunTransportConfigurationProvider
    > _stringToEnum = new()
    {
        { "vapi.websocket", SimulationRunTransportConfigurationProvider.VapiWebsocket },
        { "vapi.webchat", SimulationRunTransportConfigurationProvider.VapiWebchat },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunTransportConfigurationProvider,
        string
    > _enumToString = new()
    {
        { SimulationRunTransportConfigurationProvider.VapiWebsocket, "vapi.websocket" },
        { SimulationRunTransportConfigurationProvider.VapiWebchat, "vapi.webchat" },
    };

    public override SimulationRunTransportConfigurationProvider Read(
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
        SimulationRunTransportConfigurationProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunTransportConfigurationProvider ReadAsPropertyName(
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
        SimulationRunTransportConfigurationProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
