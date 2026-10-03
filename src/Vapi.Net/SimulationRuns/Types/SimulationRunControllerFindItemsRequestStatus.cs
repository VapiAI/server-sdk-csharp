using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindItemsRequestStatusSerializer))]
public enum SimulationRunControllerFindItemsRequestStatus
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

internal class SimulationRunControllerFindItemsRequestStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindItemsRequestStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindItemsRequestStatus
    > _stringToEnum = new()
    {
        { "queued", SimulationRunControllerFindItemsRequestStatus.Queued },
        { "running", SimulationRunControllerFindItemsRequestStatus.Running },
        { "evaluating", SimulationRunControllerFindItemsRequestStatus.Evaluating },
        { "passed", SimulationRunControllerFindItemsRequestStatus.Passed },
        { "failed", SimulationRunControllerFindItemsRequestStatus.Failed },
        { "canceled", SimulationRunControllerFindItemsRequestStatus.Canceled },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindItemsRequestStatus,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindItemsRequestStatus.Queued, "queued" },
        { SimulationRunControllerFindItemsRequestStatus.Running, "running" },
        { SimulationRunControllerFindItemsRequestStatus.Evaluating, "evaluating" },
        { SimulationRunControllerFindItemsRequestStatus.Passed, "passed" },
        { SimulationRunControllerFindItemsRequestStatus.Failed, "failed" },
        { SimulationRunControllerFindItemsRequestStatus.Canceled, "canceled" },
    };

    public override SimulationRunControllerFindItemsRequestStatus Read(
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
        SimulationRunControllerFindItemsRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindItemsRequestStatus ReadAsPropertyName(
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
        SimulationRunControllerFindItemsRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
