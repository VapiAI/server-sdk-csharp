using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunStatusSerializer))]
public enum SimulationRunStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "ended")]
    Ended,
}

internal class SimulationRunStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunStatus
    > _stringToEnum = new()
    {
        { "queued", SimulationRunStatus.Queued },
        { "running", SimulationRunStatus.Running },
        { "ended", SimulationRunStatus.Ended },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunStatus,
        string
    > _enumToString = new()
    {
        { SimulationRunStatus.Queued, "queued" },
        { SimulationRunStatus.Running, "running" },
        { SimulationRunStatus.Ended, "ended" },
    };

    public override SimulationRunStatus Read(
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
        SimulationRunStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunStatus ReadAsPropertyName(
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
        SimulationRunStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
