using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CustomEndpointingModelSmartEndpointingPlanProviderSerializer))]
public enum CustomEndpointingModelSmartEndpointingPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "livekit")]
    Livekit,

    [EnumMember(Value = "custom-endpointing-model")]
    CustomEndpointingModel,
}

internal class CustomEndpointingModelSmartEndpointingPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CustomEndpointingModelSmartEndpointingPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CustomEndpointingModelSmartEndpointingPlanProvider
    > _stringToEnum = new()
    {
        { "vapi", CustomEndpointingModelSmartEndpointingPlanProvider.Vapi },
        { "livekit", CustomEndpointingModelSmartEndpointingPlanProvider.Livekit },
        {
            "custom-endpointing-model",
            CustomEndpointingModelSmartEndpointingPlanProvider.CustomEndpointingModel
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CustomEndpointingModelSmartEndpointingPlanProvider,
        string
    > _enumToString = new()
    {
        { CustomEndpointingModelSmartEndpointingPlanProvider.Vapi, "vapi" },
        { CustomEndpointingModelSmartEndpointingPlanProvider.Livekit, "livekit" },
        {
            CustomEndpointingModelSmartEndpointingPlanProvider.CustomEndpointingModel,
            "custom-endpointing-model"
        },
    };

    public override CustomEndpointingModelSmartEndpointingPlanProvider Read(
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
        CustomEndpointingModelSmartEndpointingPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CustomEndpointingModelSmartEndpointingPlanProvider ReadAsPropertyName(
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
        CustomEndpointingModelSmartEndpointingPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
