using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(
    typeof(ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBySerializer)
)]
public enum ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy
    > _stringToEnum = new()
    {
        {
            "createdAt",
            ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy.CreatedAt
        },
        {
            "duration",
            ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy.Duration
        },
        { "cost", ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy,
        string
    > _enumToString = new()
    {
        {
            ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy.CreatedAt,
            "createdAt"
        },
        {
            ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy.Duration,
            "duration"
        },
        { ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy.Cost, "cost" },
    };

    public override ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy Read(
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
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy ReadAsPropertyName(
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
        ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
