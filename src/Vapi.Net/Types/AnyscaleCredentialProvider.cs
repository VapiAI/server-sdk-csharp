using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnyscaleCredentialProviderSerializer))]
public enum AnyscaleCredentialProvider
{
    [EnumMember(Value = "anyscale")]
    Anyscale,
}

internal class AnyscaleCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnyscaleCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnyscaleCredentialProvider
    > _stringToEnum = new() { { "anyscale", AnyscaleCredentialProvider.Anyscale } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnyscaleCredentialProvider,
        string
    > _enumToString = new() { { AnyscaleCredentialProvider.Anyscale, "anyscale" } };

    public override AnyscaleCredentialProvider Read(
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
        AnyscaleCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnyscaleCredentialProvider ReadAsPropertyName(
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
        AnyscaleCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
