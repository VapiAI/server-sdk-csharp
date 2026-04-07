using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetEvalPaginatedDtoSortOrderSerializer))]
public enum GetEvalPaginatedDtoSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class GetEvalPaginatedDtoSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetEvalPaginatedDtoSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetEvalPaginatedDtoSortOrder
    > _stringToEnum = new()
    {
        { "ASC", GetEvalPaginatedDtoSortOrder.Asc },
        { "DESC", GetEvalPaginatedDtoSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetEvalPaginatedDtoSortOrder,
        string
    > _enumToString = new()
    {
        { GetEvalPaginatedDtoSortOrder.Asc, "ASC" },
        { GetEvalPaginatedDtoSortOrder.Desc, "DESC" },
    };

    public override GetEvalPaginatedDtoSortOrder Read(
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
        GetEvalPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetEvalPaginatedDtoSortOrder ReadAsPropertyName(
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
        GetEvalPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
