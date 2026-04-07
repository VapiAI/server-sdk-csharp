using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ProviderResourceControllerGetProviderResourceRequestProviderSerializer))]
public enum ProviderResourceControllerGetProviderResourceRequestProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "11labs")]
    ElevenLabs,
}

internal class ProviderResourceControllerGetProviderResourceRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerGetProviderResourceRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerGetProviderResourceRequestProvider
    > _stringToEnum = new()
    {
        { "cartesia", ProviderResourceControllerGetProviderResourceRequestProvider.Cartesia },
        { "11labs", ProviderResourceControllerGetProviderResourceRequestProvider.ElevenLabs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerGetProviderResourceRequestProvider,
        string
    > _enumToString = new()
    {
        { ProviderResourceControllerGetProviderResourceRequestProvider.Cartesia, "cartesia" },
        { ProviderResourceControllerGetProviderResourceRequestProvider.ElevenLabs, "11labs" },
    };

    public override ProviderResourceControllerGetProviderResourceRequestProvider Read(
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
        ProviderResourceControllerGetProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerGetProviderResourceRequestProvider ReadAsPropertyName(
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
        ProviderResourceControllerGetProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
