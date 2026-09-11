using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetEvalPaginatedDtoSortBySerializer))]
public enum GetEvalPaginatedDtoSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class GetEvalPaginatedDtoSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetEvalPaginatedDtoSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetEvalPaginatedDtoSortBy
    > _stringToEnum = new()
    {
        { "createdAt", GetEvalPaginatedDtoSortBy.CreatedAt },
        { "duration", GetEvalPaginatedDtoSortBy.Duration },
        { "cost", GetEvalPaginatedDtoSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetEvalPaginatedDtoSortBy,
        string
    > _enumToString = new()
    {
        { GetEvalPaginatedDtoSortBy.CreatedAt, "createdAt" },
        { GetEvalPaginatedDtoSortBy.Duration, "duration" },
        { GetEvalPaginatedDtoSortBy.Cost, "cost" },
    };

    public override GetEvalPaginatedDtoSortBy Read(
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
        GetEvalPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetEvalPaginatedDtoSortBy ReadAsPropertyName(
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
        GetEvalPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
