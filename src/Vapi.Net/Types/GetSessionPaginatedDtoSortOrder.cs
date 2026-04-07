using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetSessionPaginatedDtoSortOrderSerializer))]
public enum GetSessionPaginatedDtoSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class GetSessionPaginatedDtoSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetSessionPaginatedDtoSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetSessionPaginatedDtoSortOrder
    > _stringToEnum = new()
    {
        { "ASC", GetSessionPaginatedDtoSortOrder.Asc },
        { "DESC", GetSessionPaginatedDtoSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetSessionPaginatedDtoSortOrder,
        string
    > _enumToString = new()
    {
        { GetSessionPaginatedDtoSortOrder.Asc, "ASC" },
        { GetSessionPaginatedDtoSortOrder.Desc, "DESC" },
    };

    public override GetSessionPaginatedDtoSortOrder Read(
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
        GetSessionPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetSessionPaginatedDtoSortOrder ReadAsPropertyName(
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
        GetSessionPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
