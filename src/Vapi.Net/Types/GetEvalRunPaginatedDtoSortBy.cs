using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetEvalRunPaginatedDtoSortBySerializer))]
public enum GetEvalRunPaginatedDtoSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class GetEvalRunPaginatedDtoSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetEvalRunPaginatedDtoSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetEvalRunPaginatedDtoSortBy
    > _stringToEnum = new()
    {
        { "createdAt", GetEvalRunPaginatedDtoSortBy.CreatedAt },
        { "duration", GetEvalRunPaginatedDtoSortBy.Duration },
        { "cost", GetEvalRunPaginatedDtoSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetEvalRunPaginatedDtoSortBy,
        string
    > _enumToString = new()
    {
        { GetEvalRunPaginatedDtoSortBy.CreatedAt, "createdAt" },
        { GetEvalRunPaginatedDtoSortBy.Duration, "duration" },
        { GetEvalRunPaginatedDtoSortBy.Cost, "cost" },
    };

    public override GetEvalRunPaginatedDtoSortBy Read(
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
        GetEvalRunPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetEvalRunPaginatedDtoSortBy ReadAsPropertyName(
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
        GetEvalRunPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
