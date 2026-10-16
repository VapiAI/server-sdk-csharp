using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunListItemStatusSerializer))]
public enum SimulationRunListItemStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "ended")]
    Ended,
}

internal class SimulationRunListItemStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunListItemStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunListItemStatus
    > _stringToEnum = new()
    {
        { "queued", SimulationRunListItemStatus.Queued },
        { "running", SimulationRunListItemStatus.Running },
        { "ended", SimulationRunListItemStatus.Ended },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunListItemStatus,
        string
    > _enumToString = new()
    {
        { SimulationRunListItemStatus.Queued, "queued" },
        { SimulationRunListItemStatus.Running, "running" },
        { SimulationRunListItemStatus.Ended, "ended" },
    };

    public override SimulationRunListItemStatus Read(
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
        SimulationRunListItemStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunListItemStatus ReadAsPropertyName(
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
        SimulationRunListItemStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
