using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VonageCredentialProviderSerializer))]
public enum VonageCredentialProvider
{
    [EnumMember(Value = "vonage")]
    Vonage,
}

internal class VonageCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VonageCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VonageCredentialProvider
    > _stringToEnum = new() { { "vonage", VonageCredentialProvider.Vonage } };

    private static readonly global::System.Collections.Generic.Dictionary<
        VonageCredentialProvider,
        string
    > _enumToString = new() { { VonageCredentialProvider.Vonage, "vonage" } };

    public override VonageCredentialProvider Read(
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
        VonageCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VonageCredentialProvider ReadAsPropertyName(
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
        VonageCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
