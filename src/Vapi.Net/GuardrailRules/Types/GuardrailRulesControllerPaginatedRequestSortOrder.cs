using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailRulesControllerPaginatedRequestSortOrderSerializer))]
public enum GuardrailRulesControllerPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class GuardrailRulesControllerPaginatedRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailRulesControllerPaginatedRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailRulesControllerPaginatedRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", GuardrailRulesControllerPaginatedRequestSortOrder.Asc },
        { "DESC", GuardrailRulesControllerPaginatedRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailRulesControllerPaginatedRequestSortOrder,
        string
    > _enumToString = new()
    {
        { GuardrailRulesControllerPaginatedRequestSortOrder.Asc, "ASC" },
        { GuardrailRulesControllerPaginatedRequestSortOrder.Desc, "DESC" },
    };

    public override GuardrailRulesControllerPaginatedRequestSortOrder Read(
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
        GuardrailRulesControllerPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailRulesControllerPaginatedRequestSortOrder ReadAsPropertyName(
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
        GuardrailRulesControllerPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
