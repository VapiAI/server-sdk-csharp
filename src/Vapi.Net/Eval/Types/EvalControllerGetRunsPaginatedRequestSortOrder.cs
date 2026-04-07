using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalControllerGetRunsPaginatedRequestSortOrderSerializer))]
public enum EvalControllerGetRunsPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class EvalControllerGetRunsPaginatedRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalControllerGetRunsPaginatedRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalControllerGetRunsPaginatedRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", EvalControllerGetRunsPaginatedRequestSortOrder.Asc },
        { "DESC", EvalControllerGetRunsPaginatedRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalControllerGetRunsPaginatedRequestSortOrder,
        string
    > _enumToString = new()
    {
        { EvalControllerGetRunsPaginatedRequestSortOrder.Asc, "ASC" },
        { EvalControllerGetRunsPaginatedRequestSortOrder.Desc, "DESC" },
    };

    public override EvalControllerGetRunsPaginatedRequestSortOrder Read(
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
        EvalControllerGetRunsPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalControllerGetRunsPaginatedRequestSortOrder ReadAsPropertyName(
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
        EvalControllerGetRunsPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
