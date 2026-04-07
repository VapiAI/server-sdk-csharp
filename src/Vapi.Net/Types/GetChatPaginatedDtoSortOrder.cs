using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetChatPaginatedDtoSortOrderSerializer))]
public enum GetChatPaginatedDtoSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class GetChatPaginatedDtoSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetChatPaginatedDtoSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetChatPaginatedDtoSortOrder
    > _stringToEnum = new()
    {
        { "ASC", GetChatPaginatedDtoSortOrder.Asc },
        { "DESC", GetChatPaginatedDtoSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetChatPaginatedDtoSortOrder,
        string
    > _enumToString = new()
    {
        { GetChatPaginatedDtoSortOrder.Asc, "ASC" },
        { GetChatPaginatedDtoSortOrder.Desc, "DESC" },
    };

    public override GetChatPaginatedDtoSortOrder Read(
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
        GetChatPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetChatPaginatedDtoSortOrder ReadAsPropertyName(
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
        GetChatPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
