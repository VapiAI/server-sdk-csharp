using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ProviderResourceControllerDeleteProviderResourceRequestProviderSerializer))]
public enum ProviderResourceControllerDeleteProviderResourceRequestProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "11labs")]
    ElevenLabs,
}

internal class ProviderResourceControllerDeleteProviderResourceRequestProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerDeleteProviderResourceRequestProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerDeleteProviderResourceRequestProvider
    > _stringToEnum = new()
    {
        { "cartesia", ProviderResourceControllerDeleteProviderResourceRequestProvider.Cartesia },
        { "11labs", ProviderResourceControllerDeleteProviderResourceRequestProvider.ElevenLabs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerDeleteProviderResourceRequestProvider,
        string
    > _enumToString = new()
    {
        { ProviderResourceControllerDeleteProviderResourceRequestProvider.Cartesia, "cartesia" },
        { ProviderResourceControllerDeleteProviderResourceRequestProvider.ElevenLabs, "11labs" },
    };

    public override ProviderResourceControllerDeleteProviderResourceRequestProvider Read(
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
        ProviderResourceControllerDeleteProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerDeleteProviderResourceRequestProvider ReadAsPropertyName(
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
        ProviderResourceControllerDeleteProviderResourceRequestProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
