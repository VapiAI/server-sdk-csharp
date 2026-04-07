using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ListChatsRequestSortOrderSerializer))]
public enum ListChatsRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class ListChatsRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ListChatsRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ListChatsRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", ListChatsRequestSortOrder.Asc },
        { "DESC", ListChatsRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ListChatsRequestSortOrder,
        string
    > _enumToString = new()
    {
        { ListChatsRequestSortOrder.Asc, "ASC" },
        { ListChatsRequestSortOrder.Desc, "DESC" },
    };

    public override ListChatsRequestSortOrder Read(
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
        ListChatsRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ListChatsRequestSortOrder ReadAsPropertyName(
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
        ListChatsRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
