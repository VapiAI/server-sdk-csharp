using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationOnboardingRequirementDtoTagSerializer))]
public enum SimulationOnboardingRequirementDtoTag
{
    [EnumMember(Value = "assumption")]
    Assumption,

    [EnumMember(Value = "not-testable")]
    NotTestable,

    [EnumMember(Value = "voice-only")]
    VoiceOnly,
}

internal class SimulationOnboardingRequirementDtoTagSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationOnboardingRequirementDtoTag>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationOnboardingRequirementDtoTag
    > _stringToEnum = new()
    {
        { "assumption", SimulationOnboardingRequirementDtoTag.Assumption },
        { "not-testable", SimulationOnboardingRequirementDtoTag.NotTestable },
        { "voice-only", SimulationOnboardingRequirementDtoTag.VoiceOnly },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationOnboardingRequirementDtoTag,
        string
    > _enumToString = new()
    {
        { SimulationOnboardingRequirementDtoTag.Assumption, "assumption" },
        { SimulationOnboardingRequirementDtoTag.NotTestable, "not-testable" },
        { SimulationOnboardingRequirementDtoTag.VoiceOnly, "voice-only" },
    };

    public override SimulationOnboardingRequirementDtoTag Read(
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
        SimulationOnboardingRequirementDtoTag value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationOnboardingRequirementDtoTag ReadAsPropertyName(
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
        SimulationOnboardingRequirementDtoTag value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
