using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(StructuredOutputControllerFindAllRequestSortBySerializer))]
public enum StructuredOutputControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class StructuredOutputControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<StructuredOutputControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        StructuredOutputControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", StructuredOutputControllerFindAllRequestSortBy.CreatedAt },
        { "duration", StructuredOutputControllerFindAllRequestSortBy.Duration },
        { "cost", StructuredOutputControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        StructuredOutputControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { StructuredOutputControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { StructuredOutputControllerFindAllRequestSortBy.Duration, "duration" },
        { StructuredOutputControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override StructuredOutputControllerFindAllRequestSortBy Read(
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
        StructuredOutputControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override StructuredOutputControllerFindAllRequestSortBy ReadAsPropertyName(
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
        StructuredOutputControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
