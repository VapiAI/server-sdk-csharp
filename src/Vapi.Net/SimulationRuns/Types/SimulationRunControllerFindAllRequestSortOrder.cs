using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunControllerFindAllRequestSortOrderSerializer))]
public enum SimulationRunControllerFindAllRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class SimulationRunControllerFindAllRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunControllerFindAllRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunControllerFindAllRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", SimulationRunControllerFindAllRequestSortOrder.Asc },
        { "DESC", SimulationRunControllerFindAllRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunControllerFindAllRequestSortOrder,
        string
    > _enumToString = new()
    {
        { SimulationRunControllerFindAllRequestSortOrder.Asc, "ASC" },
        { SimulationRunControllerFindAllRequestSortOrder.Desc, "DESC" },
    };

    public override SimulationRunControllerFindAllRequestSortOrder Read(
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
        SimulationRunControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunControllerFindAllRequestSortOrder ReadAsPropertyName(
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
        SimulationRunControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
