using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationOnboardingToolGapDtoReasonSerializer))]
public enum SimulationOnboardingToolGapDtoReason
{
    [EnumMember(Value = "dynamic-handoff")]
    DynamicHandoff,

    [EnumMember(Value = "destination-not-plain")]
    DestinationNotPlain,

    [EnumMember(Value = "destination-unresolved")]
    DestinationUnresolved,

    [EnumMember(Value = "destination-truncated")]
    DestinationTruncated,

    [EnumMember(Value = "transfer-external")]
    TransferExternal,

    [EnumMember(Value = "destination-name-unscoped")]
    DestinationNameUnscoped,

    [EnumMember(Value = "native-tool-shadowed")]
    NativeToolShadowed,
}

internal class SimulationOnboardingToolGapDtoReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationOnboardingToolGapDtoReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationOnboardingToolGapDtoReason
    > _stringToEnum = new()
    {
        { "dynamic-handoff", SimulationOnboardingToolGapDtoReason.DynamicHandoff },
        { "destination-not-plain", SimulationOnboardingToolGapDtoReason.DestinationNotPlain },
        { "destination-unresolved", SimulationOnboardingToolGapDtoReason.DestinationUnresolved },
        { "destination-truncated", SimulationOnboardingToolGapDtoReason.DestinationTruncated },
        { "transfer-external", SimulationOnboardingToolGapDtoReason.TransferExternal },
        {
            "destination-name-unscoped",
            SimulationOnboardingToolGapDtoReason.DestinationNameUnscoped
        },
        { "native-tool-shadowed", SimulationOnboardingToolGapDtoReason.NativeToolShadowed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationOnboardingToolGapDtoReason,
        string
    > _enumToString = new()
    {
        { SimulationOnboardingToolGapDtoReason.DynamicHandoff, "dynamic-handoff" },
        { SimulationOnboardingToolGapDtoReason.DestinationNotPlain, "destination-not-plain" },
        { SimulationOnboardingToolGapDtoReason.DestinationUnresolved, "destination-unresolved" },
        { SimulationOnboardingToolGapDtoReason.DestinationTruncated, "destination-truncated" },
        { SimulationOnboardingToolGapDtoReason.TransferExternal, "transfer-external" },
        {
            SimulationOnboardingToolGapDtoReason.DestinationNameUnscoped,
            "destination-name-unscoped"
        },
        { SimulationOnboardingToolGapDtoReason.NativeToolShadowed, "native-tool-shadowed" },
    };

    public override SimulationOnboardingToolGapDtoReason Read(
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
        SimulationOnboardingToolGapDtoReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationOnboardingToolGapDtoReason ReadAsPropertyName(
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
        SimulationOnboardingToolGapDtoReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
