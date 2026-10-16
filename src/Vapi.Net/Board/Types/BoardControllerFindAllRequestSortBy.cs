using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BoardControllerFindAllRequestSortBySerializer))]
public enum BoardControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class BoardControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<BoardControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BoardControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", BoardControllerFindAllRequestSortBy.CreatedAt },
        { "duration", BoardControllerFindAllRequestSortBy.Duration },
        { "cost", BoardControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BoardControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { BoardControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { BoardControllerFindAllRequestSortBy.Duration, "duration" },
        { BoardControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override BoardControllerFindAllRequestSortBy Read(
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
        BoardControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BoardControllerFindAllRequestSortBy ReadAsPropertyName(
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
        BoardControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
