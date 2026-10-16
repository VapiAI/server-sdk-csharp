using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficAllocationControllerFindAllPaginatedRequestSortOrderSerializer))]
public enum TrafficAllocationControllerFindAllPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class TrafficAllocationControllerFindAllPaginatedRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficAllocationControllerFindAllPaginatedRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficAllocationControllerFindAllPaginatedRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", TrafficAllocationControllerFindAllPaginatedRequestSortOrder.Asc },
        { "DESC", TrafficAllocationControllerFindAllPaginatedRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficAllocationControllerFindAllPaginatedRequestSortOrder,
        string
    > _enumToString = new()
    {
        { TrafficAllocationControllerFindAllPaginatedRequestSortOrder.Asc, "ASC" },
        { TrafficAllocationControllerFindAllPaginatedRequestSortOrder.Desc, "DESC" },
    };

    public override TrafficAllocationControllerFindAllPaginatedRequestSortOrder Read(
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
        TrafficAllocationControllerFindAllPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficAllocationControllerFindAllPaginatedRequestSortOrder ReadAsPropertyName(
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
        TrafficAllocationControllerFindAllPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
