using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalControllerGetRunsPaginatedRequestSortBySerializer))]
public enum EvalControllerGetRunsPaginatedRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class EvalControllerGetRunsPaginatedRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalControllerGetRunsPaginatedRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalControllerGetRunsPaginatedRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", EvalControllerGetRunsPaginatedRequestSortBy.CreatedAt },
        { "duration", EvalControllerGetRunsPaginatedRequestSortBy.Duration },
        { "cost", EvalControllerGetRunsPaginatedRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalControllerGetRunsPaginatedRequestSortBy,
        string
    > _enumToString = new()
    {
        { EvalControllerGetRunsPaginatedRequestSortBy.CreatedAt, "createdAt" },
        { EvalControllerGetRunsPaginatedRequestSortBy.Duration, "duration" },
        { EvalControllerGetRunsPaginatedRequestSortBy.Cost, "cost" },
    };

    public override EvalControllerGetRunsPaginatedRequestSortBy Read(
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
        EvalControllerGetRunsPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalControllerGetRunsPaginatedRequestSortBy ReadAsPropertyName(
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
        EvalControllerGetRunsPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
