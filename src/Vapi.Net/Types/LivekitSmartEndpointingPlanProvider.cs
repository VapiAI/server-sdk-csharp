using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LivekitSmartEndpointingPlanProviderSerializer))]
public enum LivekitSmartEndpointingPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "livekit")]
    Livekit,

    [EnumMember(Value = "custom-endpointing-model")]
    CustomEndpointingModel,
}

internal class LivekitSmartEndpointingPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LivekitSmartEndpointingPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LivekitSmartEndpointingPlanProvider
    > _stringToEnum = new()
    {
        { "vapi", LivekitSmartEndpointingPlanProvider.Vapi },
        { "livekit", LivekitSmartEndpointingPlanProvider.Livekit },
        { "custom-endpointing-model", LivekitSmartEndpointingPlanProvider.CustomEndpointingModel },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LivekitSmartEndpointingPlanProvider,
        string
    > _enumToString = new()
    {
        { LivekitSmartEndpointingPlanProvider.Vapi, "vapi" },
        { LivekitSmartEndpointingPlanProvider.Livekit, "livekit" },
        { LivekitSmartEndpointingPlanProvider.CustomEndpointingModel, "custom-endpointing-model" },
    };

    public override LivekitSmartEndpointingPlanProvider Read(
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
        LivekitSmartEndpointingPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LivekitSmartEndpointingPlanProvider ReadAsPropertyName(
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
        LivekitSmartEndpointingPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
