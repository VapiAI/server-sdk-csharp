using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetEvalRunPaginatedDtoSortOrderSerializer))]
public enum GetEvalRunPaginatedDtoSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class GetEvalRunPaginatedDtoSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetEvalRunPaginatedDtoSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetEvalRunPaginatedDtoSortOrder
    > _stringToEnum = new()
    {
        { "ASC", GetEvalRunPaginatedDtoSortOrder.Asc },
        { "DESC", GetEvalRunPaginatedDtoSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetEvalRunPaginatedDtoSortOrder,
        string
    > _enumToString = new()
    {
        { GetEvalRunPaginatedDtoSortOrder.Asc, "ASC" },
        { GetEvalRunPaginatedDtoSortOrder.Desc, "DESC" },
    };

    public override GetEvalRunPaginatedDtoSortOrder Read(
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
        GetEvalRunPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetEvalRunPaginatedDtoSortOrder ReadAsPropertyName(
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
        GetEvalRunPaginatedDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
