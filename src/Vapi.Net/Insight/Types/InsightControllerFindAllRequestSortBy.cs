using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InsightControllerFindAllRequestSortBySerializer))]
public enum InsightControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class InsightControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<InsightControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InsightControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", InsightControllerFindAllRequestSortBy.CreatedAt },
        { "duration", InsightControllerFindAllRequestSortBy.Duration },
        { "cost", InsightControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InsightControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { InsightControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { InsightControllerFindAllRequestSortBy.Duration, "duration" },
        { InsightControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override InsightControllerFindAllRequestSortBy Read(
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
        InsightControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InsightControllerFindAllRequestSortBy ReadAsPropertyName(
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
        InsightControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
