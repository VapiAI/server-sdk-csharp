using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ScorecardControllerGetPaginatedRequestSortBySerializer))]
public enum ScorecardControllerGetPaginatedRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class ScorecardControllerGetPaginatedRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<ScorecardControllerGetPaginatedRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ScorecardControllerGetPaginatedRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", ScorecardControllerGetPaginatedRequestSortBy.CreatedAt },
        { "duration", ScorecardControllerGetPaginatedRequestSortBy.Duration },
        { "cost", ScorecardControllerGetPaginatedRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ScorecardControllerGetPaginatedRequestSortBy,
        string
    > _enumToString = new()
    {
        { ScorecardControllerGetPaginatedRequestSortBy.CreatedAt, "createdAt" },
        { ScorecardControllerGetPaginatedRequestSortBy.Duration, "duration" },
        { ScorecardControllerGetPaginatedRequestSortBy.Cost, "cost" },
    };

    public override ScorecardControllerGetPaginatedRequestSortBy Read(
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
        ScorecardControllerGetPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ScorecardControllerGetPaginatedRequestSortBy ReadAsPropertyName(
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
        ScorecardControllerGetPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
