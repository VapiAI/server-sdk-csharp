using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindAllRequestFilterStatusSerializer))]
public enum SimulationRunControllerFindAllRequestFilterStatus
{
    [EnumMember(Value = "passed")]
    Passed,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "running")]
    Running,
}

internal class SimulationRunControllerFindAllRequestFilterStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindAllRequestFilterStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindAllRequestFilterStatus
    > _stringToEnum = new()
    {
        { "passed", SimulationRunControllerFindAllRequestFilterStatus.Passed },
        { "failed", SimulationRunControllerFindAllRequestFilterStatus.Failed },
        { "running", SimulationRunControllerFindAllRequestFilterStatus.Running },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindAllRequestFilterStatus,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindAllRequestFilterStatus.Passed, "passed" },
        { SimulationRunControllerFindAllRequestFilterStatus.Failed, "failed" },
        { SimulationRunControllerFindAllRequestFilterStatus.Running, "running" },
    };

    public override SimulationRunControllerFindAllRequestFilterStatus Read(
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
        SimulationRunControllerFindAllRequestFilterStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindAllRequestFilterStatus ReadAsPropertyName(
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
        SimulationRunControllerFindAllRequestFilterStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
