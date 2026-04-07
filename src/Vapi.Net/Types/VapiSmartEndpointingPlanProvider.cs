using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiSmartEndpointingPlanProviderSerializer))]
public enum VapiSmartEndpointingPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "livekit")]
    Livekit,

    [EnumMember(Value = "custom-endpointing-model")]
    CustomEndpointingModel,
}

internal class VapiSmartEndpointingPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiSmartEndpointingPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiSmartEndpointingPlanProvider
    > _stringToEnum = new()
    {
        { "vapi", VapiSmartEndpointingPlanProvider.Vapi },
        { "livekit", VapiSmartEndpointingPlanProvider.Livekit },
        { "custom-endpointing-model", VapiSmartEndpointingPlanProvider.CustomEndpointingModel },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiSmartEndpointingPlanProvider,
        string
    > _enumToString = new()
    {
        { VapiSmartEndpointingPlanProvider.Vapi, "vapi" },
        { VapiSmartEndpointingPlanProvider.Livekit, "livekit" },
        { VapiSmartEndpointingPlanProvider.CustomEndpointingModel, "custom-endpointing-model" },
    };

    public override VapiSmartEndpointingPlanProvider Read(
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
        VapiSmartEndpointingPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiSmartEndpointingPlanProvider ReadAsPropertyName(
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
        VapiSmartEndpointingPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
