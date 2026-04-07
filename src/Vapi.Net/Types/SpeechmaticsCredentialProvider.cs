using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SpeechmaticsCredentialProviderSerializer))]
public enum SpeechmaticsCredentialProvider
{
    [EnumMember(Value = "speechmatics")]
    Speechmatics,
}

internal class SpeechmaticsCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SpeechmaticsCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SpeechmaticsCredentialProvider
    > _stringToEnum = new() { { "speechmatics", SpeechmaticsCredentialProvider.Speechmatics } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SpeechmaticsCredentialProvider,
        string
    > _enumToString = new() { { SpeechmaticsCredentialProvider.Speechmatics, "speechmatics" } };

    public override SpeechmaticsCredentialProvider Read(
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
        SpeechmaticsCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SpeechmaticsCredentialProvider ReadAsPropertyName(
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
        SpeechmaticsCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
