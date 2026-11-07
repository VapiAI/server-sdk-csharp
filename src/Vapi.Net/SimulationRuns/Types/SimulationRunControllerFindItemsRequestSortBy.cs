using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindItemsRequestSortBySerializer))]
public enum SimulationRunControllerFindItemsRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class SimulationRunControllerFindItemsRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindItemsRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindItemsRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", SimulationRunControllerFindItemsRequestSortBy.CreatedAt },
        { "duration", SimulationRunControllerFindItemsRequestSortBy.Duration },
        { "cost", SimulationRunControllerFindItemsRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindItemsRequestSortBy,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindItemsRequestSortBy.CreatedAt, "createdAt" },
        { SimulationRunControllerFindItemsRequestSortBy.Duration, "duration" },
        { SimulationRunControllerFindItemsRequestSortBy.Cost, "cost" },
    };

    public override SimulationRunControllerFindItemsRequestSortBy Read(
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
        SimulationRunControllerFindItemsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindItemsRequestSortBy ReadAsPropertyName(
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
        SimulationRunControllerFindItemsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
