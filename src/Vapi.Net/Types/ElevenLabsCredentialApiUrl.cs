using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsCredentialApiUrlSerializer))]
public enum ElevenLabsCredentialApiUrl
{
    [EnumMember(Value = "https://api.elevenlabs.io")]
    HttpsApiElevenlabsIo,

    [EnumMember(Value = "https://api.eu.residency.elevenlabs.io")]
    HttpsApiEuResidencyElevenlabsIo,
}

internal class ElevenLabsCredentialApiUrlSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsCredentialApiUrl>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsCredentialApiUrl
    > _stringToEnum = new()
    {
        { "https://api.elevenlabs.io", ElevenLabsCredentialApiUrl.HttpsApiElevenlabsIo },
        {
            "https://api.eu.residency.elevenlabs.io",
            ElevenLabsCredentialApiUrl.HttpsApiEuResidencyElevenlabsIo
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsCredentialApiUrl,
        string
    > _enumToString = new()
    {
        { ElevenLabsCredentialApiUrl.HttpsApiElevenlabsIo, "https://api.elevenlabs.io" },
        {
            ElevenLabsCredentialApiUrl.HttpsApiEuResidencyElevenlabsIo,
            "https://api.eu.residency.elevenlabs.io"
        },
    };

    public override ElevenLabsCredentialApiUrl Read(
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
        ElevenLabsCredentialApiUrl value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsCredentialApiUrl ReadAsPropertyName(
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
        ElevenLabsCredentialApiUrl value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
