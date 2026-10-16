using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationSuiteControllerFindAllRequestSortOrderSerializer))]
public enum SimulationSuiteControllerFindAllRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class SimulationSuiteControllerFindAllRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationSuiteControllerFindAllRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationSuiteControllerFindAllRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", SimulationSuiteControllerFindAllRequestSortOrder.Asc },
        { "DESC", SimulationSuiteControllerFindAllRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationSuiteControllerFindAllRequestSortOrder,
        string
    > _enumToString = new()
    {
        { SimulationSuiteControllerFindAllRequestSortOrder.Asc, "ASC" },
        { SimulationSuiteControllerFindAllRequestSortOrder.Desc, "DESC" },
    };

    public override SimulationSuiteControllerFindAllRequestSortOrder Read(
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
        SimulationSuiteControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationSuiteControllerFindAllRequestSortOrder ReadAsPropertyName(
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
        SimulationSuiteControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
