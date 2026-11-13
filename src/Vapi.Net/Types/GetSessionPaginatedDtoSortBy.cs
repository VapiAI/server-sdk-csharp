using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetSessionPaginatedDtoSortBySerializer))]
public enum GetSessionPaginatedDtoSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class GetSessionPaginatedDtoSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetSessionPaginatedDtoSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetSessionPaginatedDtoSortBy
    > _stringToEnum = new()
    {
        { "createdAt", GetSessionPaginatedDtoSortBy.CreatedAt },
        { "duration", GetSessionPaginatedDtoSortBy.Duration },
        { "cost", GetSessionPaginatedDtoSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetSessionPaginatedDtoSortBy,
        string
    > _enumToString = new()
    {
        { GetSessionPaginatedDtoSortBy.CreatedAt, "createdAt" },
        { GetSessionPaginatedDtoSortBy.Duration, "duration" },
        { GetSessionPaginatedDtoSortBy.Cost, "cost" },
    };

    public override GetSessionPaginatedDtoSortBy Read(
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
        GetSessionPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetSessionPaginatedDtoSortBy ReadAsPropertyName(
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
        GetSessionPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
