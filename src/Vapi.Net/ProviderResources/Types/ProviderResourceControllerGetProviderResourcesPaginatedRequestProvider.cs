using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(
    typeof(ProviderResourceControllerGetProviderResourcesPaginatedRequestProviderSerializer)
)]
public enum ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "11labs")]
    ElevenLabs,
}

internal class ProviderResourceControllerGetProviderResourcesPaginatedRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider
    > _stringToEnum = new()
    {
        {
            "cartesia",
            ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider.Cartesia
        },
        {
            "11labs",
            ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider.ElevenLabs
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider,
        string
    > _enumToString = new()
    {
        {
            ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider.Cartesia,
            "cartesia"
        },
        {
            ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider.ElevenLabs,
            "11labs"
        },
    };

    public override ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider Read(
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
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider ReadAsPropertyName(
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
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
