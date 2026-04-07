using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ExportChatDtoColumnsSerializer))]
public enum ExportChatDtoColumns
{
    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "squadId")]
    SquadId,

    [EnumMember(Value = "sessionId")]
    SessionId,

    [EnumMember(Value = "previousChatId")]
    PreviousChatId,

    [EnumMember(Value = "cost")]
    Cost,

    [EnumMember(Value = "messages")]
    Messages,

    [EnumMember(Value = "output")]
    Output,

    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "updatedAt")]
    UpdatedAt,
}

internal class ExportChatDtoColumnsSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ExportChatDtoColumns>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ExportChatDtoColumns
    > _stringToEnum = new()
    {
        { "id", ExportChatDtoColumns.Id },
        { "assistantId", ExportChatDtoColumns.AssistantId },
        { "squadId", ExportChatDtoColumns.SquadId },
        { "sessionId", ExportChatDtoColumns.SessionId },
        { "previousChatId", ExportChatDtoColumns.PreviousChatId },
        { "cost", ExportChatDtoColumns.Cost },
        { "messages", ExportChatDtoColumns.Messages },
        { "output", ExportChatDtoColumns.Output },
        { "createdAt", ExportChatDtoColumns.CreatedAt },
        { "updatedAt", ExportChatDtoColumns.UpdatedAt },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ExportChatDtoColumns,
        string
    > _enumToString = new()
    {
        { ExportChatDtoColumns.Id, "id" },
        { ExportChatDtoColumns.AssistantId, "assistantId" },
        { ExportChatDtoColumns.SquadId, "squadId" },
        { ExportChatDtoColumns.SessionId, "sessionId" },
        { ExportChatDtoColumns.PreviousChatId, "previousChatId" },
        { ExportChatDtoColumns.Cost, "cost" },
        { ExportChatDtoColumns.Messages, "messages" },
        { ExportChatDtoColumns.Output, "output" },
        { ExportChatDtoColumns.CreatedAt, "createdAt" },
        { ExportChatDtoColumns.UpdatedAt, "updatedAt" },
    };

    public override ExportChatDtoColumns Read(
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
        ExportChatDtoColumns value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ExportChatDtoColumns ReadAsPropertyName(
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
        ExportChatDtoColumns value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
