using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiPronunciationDictionaryLocatorProviderSerializer))]
public enum VapiPronunciationDictionaryLocatorProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "11labs")]
    ElevenLabs,
}

internal class VapiPronunciationDictionaryLocatorProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiPronunciationDictionaryLocatorProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiPronunciationDictionaryLocatorProvider
    > _stringToEnum = new()
    {
        { "cartesia", VapiPronunciationDictionaryLocatorProvider.Cartesia },
        { "11labs", VapiPronunciationDictionaryLocatorProvider.ElevenLabs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiPronunciationDictionaryLocatorProvider,
        string
    > _enumToString = new()
    {
        { VapiPronunciationDictionaryLocatorProvider.Cartesia, "cartesia" },
        { VapiPronunciationDictionaryLocatorProvider.ElevenLabs, "11labs" },
    };

    public override VapiPronunciationDictionaryLocatorProvider Read(
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
        VapiPronunciationDictionaryLocatorProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiPronunciationDictionaryLocatorProvider ReadAsPropertyName(
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
        VapiPronunciationDictionaryLocatorProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
