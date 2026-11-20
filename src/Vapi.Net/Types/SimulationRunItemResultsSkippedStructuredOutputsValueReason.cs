using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunItemResultsSkippedStructuredOutputsValueReasonSerializer))]
public enum SimulationRunItemResultsSkippedStructuredOutputsValueReason
{
    [EnumMember(Value = "audio-not-supported")]
    AudioNotSupported,
}

internal class SimulationRunItemResultsSkippedStructuredOutputsValueReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunItemResultsSkippedStructuredOutputsValueReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunItemResultsSkippedStructuredOutputsValueReason
    > _stringToEnum = new()
    {
        {
            "audio-not-supported",
            SimulationRunItemResultsSkippedStructuredOutputsValueReason.AudioNotSupported
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunItemResultsSkippedStructuredOutputsValueReason,
        string
    > _enumToString = new()
    {
        {
            SimulationRunItemResultsSkippedStructuredOutputsValueReason.AudioNotSupported,
            "audio-not-supported"
        },
    };

    public override SimulationRunItemResultsSkippedStructuredOutputsValueReason Read(
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
        SimulationRunItemResultsSkippedStructuredOutputsValueReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunItemResultsSkippedStructuredOutputsValueReason ReadAsPropertyName(
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
        SimulationRunItemResultsSkippedStructuredOutputsValueReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
