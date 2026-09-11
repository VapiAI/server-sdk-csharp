using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateDeepgramCredentialDtoProviderSerializer))]
public enum UpdateDeepgramCredentialDtoProvider
{
    [EnumMember(Value = "deepgram")]
    Deepgram,
}

internal class UpdateDeepgramCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateDeepgramCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateDeepgramCredentialDtoProvider
    > _stringToEnum = new() { { "deepgram", UpdateDeepgramCredentialDtoProvider.Deepgram } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateDeepgramCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateDeepgramCredentialDtoProvider.Deepgram, "deepgram" } };

    public override UpdateDeepgramCredentialDtoProvider Read(
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
        UpdateDeepgramCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateDeepgramCredentialDtoProvider ReadAsPropertyName(
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
        UpdateDeepgramCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
