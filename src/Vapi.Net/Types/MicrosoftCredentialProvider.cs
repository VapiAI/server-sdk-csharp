using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MicrosoftCredentialProviderSerializer))]
public enum MicrosoftCredentialProvider
{
    [EnumMember(Value = "microsoft")]
    Microsoft,
}

internal class MicrosoftCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MicrosoftCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MicrosoftCredentialProvider
    > _stringToEnum = new() { { "microsoft", MicrosoftCredentialProvider.Microsoft } };

    private static readonly global::System.Collections.Generic.Dictionary<
        MicrosoftCredentialProvider,
        string
    > _enumToString = new() { { MicrosoftCredentialProvider.Microsoft, "microsoft" } };

    public override MicrosoftCredentialProvider Read(
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
        MicrosoftCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MicrosoftCredentialProvider ReadAsPropertyName(
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
        MicrosoftCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
