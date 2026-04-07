using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepgramCredentialProviderSerializer))]
public enum DeepgramCredentialProvider
{
    [EnumMember(Value = "deepgram")]
    Deepgram,
}

internal class DeepgramCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepgramCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepgramCredentialProvider
    > _stringToEnum = new() { { "deepgram", DeepgramCredentialProvider.Deepgram } };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepgramCredentialProvider,
        string
    > _enumToString = new() { { DeepgramCredentialProvider.Deepgram, "deepgram" } };

    public override DeepgramCredentialProvider Read(
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
        DeepgramCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepgramCredentialProvider ReadAsPropertyName(
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
        DeepgramCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
