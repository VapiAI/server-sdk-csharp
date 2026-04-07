using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ExportChatDtoSortOrderSerializer))]
public enum ExportChatDtoSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class ExportChatDtoSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ExportChatDtoSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ExportChatDtoSortOrder
    > _stringToEnum = new()
    {
        { "ASC", ExportChatDtoSortOrder.Asc },
        { "DESC", ExportChatDtoSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ExportChatDtoSortOrder,
        string
    > _enumToString = new()
    {
        { ExportChatDtoSortOrder.Asc, "ASC" },
        { ExportChatDtoSortOrder.Desc, "DESC" },
    };

    public override ExportChatDtoSortOrder Read(
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
        ExportChatDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ExportChatDtoSortOrder ReadAsPropertyName(
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
        ExportChatDtoSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
