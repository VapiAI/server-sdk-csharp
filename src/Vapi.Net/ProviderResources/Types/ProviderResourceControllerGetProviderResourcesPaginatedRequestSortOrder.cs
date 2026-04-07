using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(
    typeof(ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrderSerializer)
)]
public enum ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder.Asc },
        { "DESC", ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder,
        string
    > _enumToString = new()
    {
        { ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder.Asc, "ASC" },
        { ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder.Desc, "DESC" },
    };

    public override ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder Read(
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
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder ReadAsPropertyName(
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
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
