using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ListSessionsRequestSortOrderSerializer))]
public enum ListSessionsRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class ListSessionsRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ListSessionsRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ListSessionsRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", ListSessionsRequestSortOrder.Asc },
        { "DESC", ListSessionsRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ListSessionsRequestSortOrder,
        string
    > _enumToString = new()
    {
        { ListSessionsRequestSortOrder.Asc, "ASC" },
        { ListSessionsRequestSortOrder.Desc, "DESC" },
    };

    public override ListSessionsRequestSortOrder Read(
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
        ListSessionsRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ListSessionsRequestSortOrder ReadAsPropertyName(
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
        ListSessionsRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
