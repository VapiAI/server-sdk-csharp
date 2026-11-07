using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationOnboardingErrorDtoCodeSerializer))]
public enum SimulationOnboardingErrorDtoCode
{
    [EnumMember(Value = "SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS")]
    SimulationOnboardingGenerationInProgress,

    [EnumMember(Value = "SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED")]
    SimulationOnboardingIdempotencyKeyReused,

    [EnumMember(Value = "SIMULATION_ONBOARDING_CONCURRENCY_LIMITED")]
    SimulationOnboardingConcurrencyLimited,

    [EnumMember(Value = "SIMULATION_ONBOARDING_QUOTA_EXCEEDED")]
    SimulationOnboardingQuotaExceeded,

    [EnumMember(Value = "SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE")]
    SimulationOnboardingQuotaUnavailable,
}

internal class SimulationOnboardingErrorDtoCodeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationOnboardingErrorDtoCode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationOnboardingErrorDtoCode
    > _stringToEnum = new()
    {
        {
            "SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS",
            SimulationOnboardingErrorDtoCode.SimulationOnboardingGenerationInProgress
        },
        {
            "SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED",
            SimulationOnboardingErrorDtoCode.SimulationOnboardingIdempotencyKeyReused
        },
        {
            "SIMULATION_ONBOARDING_CONCURRENCY_LIMITED",
            SimulationOnboardingErrorDtoCode.SimulationOnboardingConcurrencyLimited
        },
        {
            "SIMULATION_ONBOARDING_QUOTA_EXCEEDED",
            SimulationOnboardingErrorDtoCode.SimulationOnboardingQuotaExceeded
        },
        {
            "SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE",
            SimulationOnboardingErrorDtoCode.SimulationOnboardingQuotaUnavailable
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationOnboardingErrorDtoCode,
        string
    > _enumToString = new()
    {
        {
            SimulationOnboardingErrorDtoCode.SimulationOnboardingGenerationInProgress,
            "SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS"
        },
        {
            SimulationOnboardingErrorDtoCode.SimulationOnboardingIdempotencyKeyReused,
            "SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED"
        },
        {
            SimulationOnboardingErrorDtoCode.SimulationOnboardingConcurrencyLimited,
            "SIMULATION_ONBOARDING_CONCURRENCY_LIMITED"
        },
        {
            SimulationOnboardingErrorDtoCode.SimulationOnboardingQuotaExceeded,
            "SIMULATION_ONBOARDING_QUOTA_EXCEEDED"
        },
        {
            SimulationOnboardingErrorDtoCode.SimulationOnboardingQuotaUnavailable,
            "SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE"
        },
    };

    public override SimulationOnboardingErrorDtoCode Read(
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
        SimulationOnboardingErrorDtoCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationOnboardingErrorDtoCode ReadAsPropertyName(
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
        SimulationOnboardingErrorDtoCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
