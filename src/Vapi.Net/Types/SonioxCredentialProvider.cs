using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SonioxCredentialProviderSerializer))]
public enum SonioxCredentialProvider
{
    [EnumMember(Value = "soniox")]
    Soniox,
}

internal class SonioxCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SonioxCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SonioxCredentialProvider
    > _stringToEnum = new() { { "soniox", SonioxCredentialProvider.Soniox } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SonioxCredentialProvider,
        string
    > _enumToString = new() { { SonioxCredentialProvider.Soniox, "soniox" } };

    public override SonioxCredentialProvider Read(
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
        SonioxCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SonioxCredentialProvider ReadAsPropertyName(
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
        SonioxCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
