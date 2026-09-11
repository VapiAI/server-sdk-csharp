using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateDeepSeekCredentialDtoProviderSerializer))]
public enum UpdateDeepSeekCredentialDtoProvider
{
    [EnumMember(Value = "deep-seek")]
    DeepSeek,
}

internal class UpdateDeepSeekCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateDeepSeekCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateDeepSeekCredentialDtoProvider
    > _stringToEnum = new() { { "deep-seek", UpdateDeepSeekCredentialDtoProvider.DeepSeek } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateDeepSeekCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateDeepSeekCredentialDtoProvider.DeepSeek, "deep-seek" } };

    public override UpdateDeepSeekCredentialDtoProvider Read(
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
        UpdateDeepSeekCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateDeepSeekCredentialDtoProvider ReadAsPropertyName(
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
        UpdateDeepSeekCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
