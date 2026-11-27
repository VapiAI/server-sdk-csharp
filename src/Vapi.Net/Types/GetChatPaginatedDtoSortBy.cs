using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetChatPaginatedDtoSortBySerializer))]
public enum GetChatPaginatedDtoSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class GetChatPaginatedDtoSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetChatPaginatedDtoSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetChatPaginatedDtoSortBy
    > _stringToEnum = new()
    {
        { "createdAt", GetChatPaginatedDtoSortBy.CreatedAt },
        { "duration", GetChatPaginatedDtoSortBy.Duration },
        { "cost", GetChatPaginatedDtoSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetChatPaginatedDtoSortBy,
        string
    > _enumToString = new()
    {
        { GetChatPaginatedDtoSortBy.CreatedAt, "createdAt" },
        { GetChatPaginatedDtoSortBy.Duration, "duration" },
        { GetChatPaginatedDtoSortBy.Cost, "cost" },
    };

    public override GetChatPaginatedDtoSortBy Read(
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
        GetChatPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetChatPaginatedDtoSortBy ReadAsPropertyName(
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
        GetChatPaginatedDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
