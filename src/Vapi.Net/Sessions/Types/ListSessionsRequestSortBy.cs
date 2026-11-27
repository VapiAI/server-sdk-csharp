using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ListSessionsRequestSortBySerializer))]
public enum ListSessionsRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class ListSessionsRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<ListSessionsRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ListSessionsRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", ListSessionsRequestSortBy.CreatedAt },
        { "duration", ListSessionsRequestSortBy.Duration },
        { "cost", ListSessionsRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ListSessionsRequestSortBy,
        string
    > _enumToString = new()
    {
        { ListSessionsRequestSortBy.CreatedAt, "createdAt" },
        { ListSessionsRequestSortBy.Duration, "duration" },
        { ListSessionsRequestSortBy.Cost, "cost" },
    };

    public override ListSessionsRequestSortBy Read(
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
        ListSessionsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ListSessionsRequestSortBy ReadAsPropertyName(
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
        ListSessionsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
