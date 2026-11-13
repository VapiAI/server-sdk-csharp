using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ScenarioControllerFindAllRequestSortOrderSerializer))]
public enum ScenarioControllerFindAllRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class ScenarioControllerFindAllRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ScenarioControllerFindAllRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ScenarioControllerFindAllRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", ScenarioControllerFindAllRequestSortOrder.Asc },
        { "DESC", ScenarioControllerFindAllRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ScenarioControllerFindAllRequestSortOrder,
        string
    > _enumToString = new()
    {
        { ScenarioControllerFindAllRequestSortOrder.Asc, "ASC" },
        { ScenarioControllerFindAllRequestSortOrder.Desc, "DESC" },
    };

    public override ScenarioControllerFindAllRequestSortOrder Read(
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
        ScenarioControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ScenarioControllerFindAllRequestSortOrder ReadAsPropertyName(
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
        ScenarioControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
