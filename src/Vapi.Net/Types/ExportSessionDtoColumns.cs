using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ExportSessionDtoColumnsSerializer))]
public enum ExportSessionDtoColumns
{
    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "name")]
    Name,

    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "squadId")]
    SquadId,

    [EnumMember(Value = "customerName")]
    CustomerName,

    [EnumMember(Value = "customerNumber")]
    CustomerNumber,

    [EnumMember(Value = "phoneNumberId")]
    PhoneNumberId,

    [EnumMember(Value = "cost")]
    Cost,

    [EnumMember(Value = "messages")]
    Messages,

    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "updatedAt")]
    UpdatedAt,
}

internal class ExportSessionDtoColumnsSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ExportSessionDtoColumns>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ExportSessionDtoColumns
    > _stringToEnum = new()
    {
        { "id", ExportSessionDtoColumns.Id },
        { "name", ExportSessionDtoColumns.Name },
        { "status", ExportSessionDtoColumns.Status },
        { "assistantId", ExportSessionDtoColumns.AssistantId },
        { "squadId", ExportSessionDtoColumns.SquadId },
        { "customerName", ExportSessionDtoColumns.CustomerName },
        { "customerNumber", ExportSessionDtoColumns.CustomerNumber },
        { "phoneNumberId", ExportSessionDtoColumns.PhoneNumberId },
        { "cost", ExportSessionDtoColumns.Cost },
        { "messages", ExportSessionDtoColumns.Messages },
        { "createdAt", ExportSessionDtoColumns.CreatedAt },
        { "updatedAt", ExportSessionDtoColumns.UpdatedAt },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ExportSessionDtoColumns,
        string
    > _enumToString = new()
    {
        { ExportSessionDtoColumns.Id, "id" },
        { ExportSessionDtoColumns.Name, "name" },
        { ExportSessionDtoColumns.Status, "status" },
        { ExportSessionDtoColumns.AssistantId, "assistantId" },
        { ExportSessionDtoColumns.SquadId, "squadId" },
        { ExportSessionDtoColumns.CustomerName, "customerName" },
        { ExportSessionDtoColumns.CustomerNumber, "customerNumber" },
        { ExportSessionDtoColumns.PhoneNumberId, "phoneNumberId" },
        { ExportSessionDtoColumns.Cost, "cost" },
        { ExportSessionDtoColumns.Messages, "messages" },
        { ExportSessionDtoColumns.CreatedAt, "createdAt" },
        { ExportSessionDtoColumns.UpdatedAt, "updatedAt" },
    };

    public override ExportSessionDtoColumns Read(
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
        ExportSessionDtoColumns value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ExportSessionDtoColumns ReadAsPropertyName(
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
        ExportSessionDtoColumns value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
