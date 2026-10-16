using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindAllRequestSortBySerializer))]
public enum SimulationRunControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class SimulationRunControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", SimulationRunControllerFindAllRequestSortBy.CreatedAt },
        { "duration", SimulationRunControllerFindAllRequestSortBy.Duration },
        { "cost", SimulationRunControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { SimulationRunControllerFindAllRequestSortBy.Duration, "duration" },
        { SimulationRunControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override SimulationRunControllerFindAllRequestSortBy Read(
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
        SimulationRunControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindAllRequestSortBy ReadAsPropertyName(
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
        SimulationRunControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
