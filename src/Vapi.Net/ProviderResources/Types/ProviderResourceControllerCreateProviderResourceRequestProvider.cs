using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ProviderResourceControllerCreateProviderResourceRequestProviderSerializer))]
public enum ProviderResourceControllerCreateProviderResourceRequestProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "11labs")]
    ElevenLabs,
}

internal class ProviderResourceControllerCreateProviderResourceRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerCreateProviderResourceRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerCreateProviderResourceRequestProvider
    > _stringToEnum = new()
    {
        { "cartesia", ProviderResourceControllerCreateProviderResourceRequestProvider.Cartesia },
        { "11labs", ProviderResourceControllerCreateProviderResourceRequestProvider.ElevenLabs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerCreateProviderResourceRequestProvider,
        string
    > _enumToString = new()
    {
        { ProviderResourceControllerCreateProviderResourceRequestProvider.Cartesia, "cartesia" },
        { ProviderResourceControllerCreateProviderResourceRequestProvider.ElevenLabs, "11labs" },
    };

    public override ProviderResourceControllerCreateProviderResourceRequestProvider Read(
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
        ProviderResourceControllerCreateProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerCreateProviderResourceRequestProvider ReadAsPropertyName(
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
        ProviderResourceControllerCreateProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
