using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(Reson8CredentialProviderSerializer))]
public enum Reson8CredentialProvider
{
    [EnumMember(Value = "reson8")]
    Reson8,
}

internal class Reson8CredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<Reson8CredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        Reson8CredentialProvider
    > _stringToEnum = new() { { "reson8", Reson8CredentialProvider.Reson8 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        Reson8CredentialProvider,
        string
    > _enumToString = new() { { Reson8CredentialProvider.Reson8, "reson8" } };

    public override Reson8CredentialProvider Read(
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
        Reson8CredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override Reson8CredentialProvider ReadAsPropertyName(
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
        Reson8CredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
