using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PaginationMetaSortOrderSerializer))]
public enum PaginationMetaSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class PaginationMetaSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PaginationMetaSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PaginationMetaSortOrder
    > _stringToEnum = new()
    {
        { "ASC", PaginationMetaSortOrder.Asc },
        { "DESC", PaginationMetaSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PaginationMetaSortOrder,
        string
    > _enumToString = new()
    {
        { PaginationMetaSortOrder.Asc, "ASC" },
        { PaginationMetaSortOrder.Desc, "DESC" },
    };

    public override PaginationMetaSortOrder Read(
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
        PaginationMetaSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PaginationMetaSortOrder ReadAsPropertyName(
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
        PaginationMetaSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
