using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunItemStatusSerializer))]
public enum SimulationRunItemStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "evaluating")]
    Evaluating,

    [EnumMember(Value = "passed")]
    Passed,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "canceled")]
    Canceled,
}

internal class SimulationRunItemStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunItemStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunItemStatus
    > _stringToEnum = new()
    {
        { "queued", SimulationRunItemStatus.Queued },
        { "running", SimulationRunItemStatus.Running },
        { "evaluating", SimulationRunItemStatus.Evaluating },
        { "passed", SimulationRunItemStatus.Passed },
        { "failed", SimulationRunItemStatus.Failed },
        { "canceled", SimulationRunItemStatus.Canceled },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunItemStatus,
        string
    > _enumToString = new()
    {
        { SimulationRunItemStatus.Queued, "queued" },
        { SimulationRunItemStatus.Running, "running" },
        { SimulationRunItemStatus.Evaluating, "evaluating" },
        { SimulationRunItemStatus.Passed, "passed" },
        { SimulationRunItemStatus.Failed, "failed" },
        { SimulationRunItemStatus.Canceled, "canceled" },
    };

    public override SimulationRunItemStatus Read(
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
        SimulationRunItemStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunItemStatus ReadAsPropertyName(
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
        SimulationRunItemStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
