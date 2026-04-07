using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepSeekCredentialProviderSerializer))]
public enum DeepSeekCredentialProvider
{
    [EnumMember(Value = "deep-seek")]
    DeepSeek,
}

internal class DeepSeekCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepSeekCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepSeekCredentialProvider
    > _stringToEnum = new() { { "deep-seek", DeepSeekCredentialProvider.DeepSeek } };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepSeekCredentialProvider,
        string
    > _enumToString = new() { { DeepSeekCredentialProvider.DeepSeek, "deep-seek" } };

    public override DeepSeekCredentialProvider Read(
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
        DeepSeekCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepSeekCredentialProvider ReadAsPropertyName(
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
        DeepSeekCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
