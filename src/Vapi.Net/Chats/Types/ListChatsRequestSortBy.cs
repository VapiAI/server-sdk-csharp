using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ListChatsRequestSortBySerializer))]
public enum ListChatsRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class ListChatsRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<ListChatsRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ListChatsRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", ListChatsRequestSortBy.CreatedAt },
        { "duration", ListChatsRequestSortBy.Duration },
        { "cost", ListChatsRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ListChatsRequestSortBy,
        string
    > _enumToString = new()
    {
        { ListChatsRequestSortBy.CreatedAt, "createdAt" },
        { ListChatsRequestSortBy.Duration, "duration" },
        { ListChatsRequestSortBy.Cost, "cost" },
    };

    public override ListChatsRequestSortBy Read(
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
        ListChatsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ListChatsRequestSortBy ReadAsPropertyName(
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
        ListChatsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
