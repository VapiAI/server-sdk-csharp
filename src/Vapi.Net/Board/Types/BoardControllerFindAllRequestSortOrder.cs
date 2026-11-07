using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BoardControllerFindAllRequestSortOrderSerializer))]
public enum BoardControllerFindAllRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class BoardControllerFindAllRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BoardControllerFindAllRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BoardControllerFindAllRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", BoardControllerFindAllRequestSortOrder.Asc },
        { "DESC", BoardControllerFindAllRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BoardControllerFindAllRequestSortOrder,
        string
    > _enumToString = new()
    {
        { BoardControllerFindAllRequestSortOrder.Asc, "ASC" },
        { BoardControllerFindAllRequestSortOrder.Desc, "DESC" },
    };

    public override BoardControllerFindAllRequestSortOrder Read(
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
        BoardControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BoardControllerFindAllRequestSortOrder ReadAsPropertyName(
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
        BoardControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
