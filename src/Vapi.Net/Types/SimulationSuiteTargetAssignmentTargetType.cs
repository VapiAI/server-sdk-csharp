using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationSuiteTargetAssignmentTargetTypeSerializer))]
public enum SimulationSuiteTargetAssignmentTargetType
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "squad")]
    Squad,
}

internal class SimulationSuiteTargetAssignmentTargetTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationSuiteTargetAssignmentTargetType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationSuiteTargetAssignmentTargetType
    > _stringToEnum = new()
    {
        { "assistant", SimulationSuiteTargetAssignmentTargetType.Assistant },
        { "squad", SimulationSuiteTargetAssignmentTargetType.Squad },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationSuiteTargetAssignmentTargetType,
        string
    > _enumToString = new()
    {
        { SimulationSuiteTargetAssignmentTargetType.Assistant, "assistant" },
        { SimulationSuiteTargetAssignmentTargetType.Squad, "squad" },
    };

    public override SimulationSuiteTargetAssignmentTargetType Read(
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
        SimulationSuiteTargetAssignmentTargetType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationSuiteTargetAssignmentTargetType ReadAsPropertyName(
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
        SimulationSuiteTargetAssignmentTargetType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
