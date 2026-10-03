using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PersonalityControllerFindAllRequestSortOrderSerializer))]
public enum PersonalityControllerFindAllRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class PersonalityControllerFindAllRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PersonalityControllerFindAllRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PersonalityControllerFindAllRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", PersonalityControllerFindAllRequestSortOrder.Asc },
        { "DESC", PersonalityControllerFindAllRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PersonalityControllerFindAllRequestSortOrder,
        string
    > _enumToString = new()
    {
        { PersonalityControllerFindAllRequestSortOrder.Asc, "ASC" },
        { PersonalityControllerFindAllRequestSortOrder.Desc, "DESC" },
    };

    public override PersonalityControllerFindAllRequestSortOrder Read(
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
        PersonalityControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PersonalityControllerFindAllRequestSortOrder ReadAsPropertyName(
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
        PersonalityControllerFindAllRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
