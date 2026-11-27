using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationOnboardingCoverageGapDtoReasonSerializer))]
public enum SimulationOnboardingCoverageGapDtoReason
{
    [EnumMember(Value = "not-testable")]
    NotTestable,

    [EnumMember(Value = "unmapped")]
    Unmapped,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "budget")]
    Budget,
}

internal class SimulationOnboardingCoverageGapDtoReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationOnboardingCoverageGapDtoReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationOnboardingCoverageGapDtoReason
    > _stringToEnum = new()
    {
        { "not-testable", SimulationOnboardingCoverageGapDtoReason.NotTestable },
        { "unmapped", SimulationOnboardingCoverageGapDtoReason.Unmapped },
        { "failed", SimulationOnboardingCoverageGapDtoReason.Failed },
        { "budget", SimulationOnboardingCoverageGapDtoReason.Budget },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationOnboardingCoverageGapDtoReason,
        string
    > _enumToString = new()
    {
        { SimulationOnboardingCoverageGapDtoReason.NotTestable, "not-testable" },
        { SimulationOnboardingCoverageGapDtoReason.Unmapped, "unmapped" },
        { SimulationOnboardingCoverageGapDtoReason.Failed, "failed" },
        { SimulationOnboardingCoverageGapDtoReason.Budget, "budget" },
    };

    public override SimulationOnboardingCoverageGapDtoReason Read(
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
        SimulationOnboardingCoverageGapDtoReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationOnboardingCoverageGapDtoReason ReadAsPropertyName(
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
        SimulationOnboardingCoverageGapDtoReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
