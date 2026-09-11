using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateElevenLabsCredentialDtoApiUrlSerializer))]
public enum CreateElevenLabsCredentialDtoApiUrl
{
    [EnumMember(Value = "https://api.elevenlabs.io")]
    HttpsApiElevenlabsIo,

    [EnumMember(Value = "https://api.eu.residency.elevenlabs.io")]
    HttpsApiEuResidencyElevenlabsIo,
}

internal class CreateElevenLabsCredentialDtoApiUrlSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateElevenLabsCredentialDtoApiUrl>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateElevenLabsCredentialDtoApiUrl
    > _stringToEnum = new()
    {
        { "https://api.elevenlabs.io", CreateElevenLabsCredentialDtoApiUrl.HttpsApiElevenlabsIo },
        {
            "https://api.eu.residency.elevenlabs.io",
            CreateElevenLabsCredentialDtoApiUrl.HttpsApiEuResidencyElevenlabsIo
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateElevenLabsCredentialDtoApiUrl,
        string
    > _enumToString = new()
    {
        { CreateElevenLabsCredentialDtoApiUrl.HttpsApiElevenlabsIo, "https://api.elevenlabs.io" },
        {
            CreateElevenLabsCredentialDtoApiUrl.HttpsApiEuResidencyElevenlabsIo,
            "https://api.eu.residency.elevenlabs.io"
        },
    };

    public override CreateElevenLabsCredentialDtoApiUrl Read(
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
        CreateElevenLabsCredentialDtoApiUrl value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateElevenLabsCredentialDtoApiUrl ReadAsPropertyName(
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
        CreateElevenLabsCredentialDtoApiUrl value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
