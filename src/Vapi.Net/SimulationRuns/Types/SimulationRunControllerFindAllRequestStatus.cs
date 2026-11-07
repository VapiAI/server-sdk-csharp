using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindAllRequestStatusSerializer))]
public enum SimulationRunControllerFindAllRequestStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "ended")]
    Ended,
}

internal class SimulationRunControllerFindAllRequestStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindAllRequestStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindAllRequestStatus
    > _stringToEnum = new()
    {
        { "queued", SimulationRunControllerFindAllRequestStatus.Queued },
        { "running", SimulationRunControllerFindAllRequestStatus.Running },
        { "ended", SimulationRunControllerFindAllRequestStatus.Ended },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindAllRequestStatus,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindAllRequestStatus.Queued, "queued" },
        { SimulationRunControllerFindAllRequestStatus.Running, "running" },
        { SimulationRunControllerFindAllRequestStatus.Ended, "ended" },
    };

    public override SimulationRunControllerFindAllRequestStatus Read(
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
        SimulationRunControllerFindAllRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindAllRequestStatus ReadAsPropertyName(
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
        SimulationRunControllerFindAllRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
