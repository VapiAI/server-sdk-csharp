using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindItemsRequestSortOrderSerializer))]
public enum SimulationRunControllerFindItemsRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class SimulationRunControllerFindItemsRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindItemsRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindItemsRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", SimulationRunControllerFindItemsRequestSortOrder.Asc },
        { "DESC", SimulationRunControllerFindItemsRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindItemsRequestSortOrder,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindItemsRequestSortOrder.Asc, "ASC" },
        { SimulationRunControllerFindItemsRequestSortOrder.Desc, "DESC" },
    };

    public override SimulationRunControllerFindItemsRequestSortOrder Read(
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
        SimulationRunControllerFindItemsRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindItemsRequestSortOrder ReadAsPropertyName(
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
        SimulationRunControllerFindItemsRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
