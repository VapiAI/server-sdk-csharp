using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ExportChatDtoSortBySerializer))]
public enum ExportChatDtoSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class ExportChatDtoSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<ExportChatDtoSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ExportChatDtoSortBy
    > _stringToEnum = new()
    {
        { "createdAt", ExportChatDtoSortBy.CreatedAt },
        { "duration", ExportChatDtoSortBy.Duration },
        { "cost", ExportChatDtoSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ExportChatDtoSortBy,
        string
    > _enumToString = new()
    {
        { ExportChatDtoSortBy.CreatedAt, "createdAt" },
        { ExportChatDtoSortBy.Duration, "duration" },
        { ExportChatDtoSortBy.Cost, "cost" },
    };

    public override ExportChatDtoSortBy Read(
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
        ExportChatDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ExportChatDtoSortBy ReadAsPropertyName(
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
        ExportChatDtoSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
