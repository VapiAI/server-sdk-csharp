using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GuardrailPacksControllerPaginatedRequestSortBySerializer))]
public enum GuardrailPacksControllerPaginatedRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,
}

internal class GuardrailPacksControllerPaginatedRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GuardrailPacksControllerPaginatedRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GuardrailPacksControllerPaginatedRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", GuardrailPacksControllerPaginatedRequestSortBy.CreatedAt },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GuardrailPacksControllerPaginatedRequestSortBy,
        string
    > _enumToString = new()
    {
        { GuardrailPacksControllerPaginatedRequestSortBy.CreatedAt, "createdAt" },
    };

    public override GuardrailPacksControllerPaginatedRequestSortBy Read(
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
        GuardrailPacksControllerPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GuardrailPacksControllerPaginatedRequestSortBy ReadAsPropertyName(
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
        GuardrailPacksControllerPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
