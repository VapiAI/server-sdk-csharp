using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ProviderResourceControllerUpdateProviderResourceRequestProviderSerializer))]
public enum ProviderResourceControllerUpdateProviderResourceRequestProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "11labs")]
    ElevenLabs,
}

internal class ProviderResourceControllerUpdateProviderResourceRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerUpdateProviderResourceRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerUpdateProviderResourceRequestProvider
    > _stringToEnum = new()
    {
        { "cartesia", ProviderResourceControllerUpdateProviderResourceRequestProvider.Cartesia },
        { "11labs", ProviderResourceControllerUpdateProviderResourceRequestProvider.ElevenLabs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerUpdateProviderResourceRequestProvider,
        string
    > _enumToString = new()
    {
        { ProviderResourceControllerUpdateProviderResourceRequestProvider.Cartesia, "cartesia" },
        { ProviderResourceControllerUpdateProviderResourceRequestProvider.ElevenLabs, "11labs" },
    };

    public override ProviderResourceControllerUpdateProviderResourceRequestProvider Read(
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
        ProviderResourceControllerUpdateProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerUpdateProviderResourceRequestProvider ReadAsPropertyName(
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
        ProviderResourceControllerUpdateProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
