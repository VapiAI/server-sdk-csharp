using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PhoneNumberControllerFindAllPaginatedRequestSortOrderSerializer))]
public enum PhoneNumberControllerFindAllPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class PhoneNumberControllerFindAllPaginatedRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PhoneNumberControllerFindAllPaginatedRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PhoneNumberControllerFindAllPaginatedRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", PhoneNumberControllerFindAllPaginatedRequestSortOrder.Asc },
        { "DESC", PhoneNumberControllerFindAllPaginatedRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PhoneNumberControllerFindAllPaginatedRequestSortOrder,
        string
    > _enumToString = new()
    {
        { PhoneNumberControllerFindAllPaginatedRequestSortOrder.Asc, "ASC" },
        { PhoneNumberControllerFindAllPaginatedRequestSortOrder.Desc, "DESC" },
    };

    public override PhoneNumberControllerFindAllPaginatedRequestSortOrder Read(
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
        PhoneNumberControllerFindAllPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PhoneNumberControllerFindAllPaginatedRequestSortOrder ReadAsPropertyName(
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
        PhoneNumberControllerFindAllPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
