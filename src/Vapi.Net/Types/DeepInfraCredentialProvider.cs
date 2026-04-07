using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepInfraCredentialProviderSerializer))]
public enum DeepInfraCredentialProvider
{
    [EnumMember(Value = "deepinfra")]
    Deepinfra,
}

internal class DeepInfraCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepInfraCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepInfraCredentialProvider
    > _stringToEnum = new() { { "deepinfra", DeepInfraCredentialProvider.Deepinfra } };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepInfraCredentialProvider,
        string
    > _enumToString = new() { { DeepInfraCredentialProvider.Deepinfra, "deepinfra" } };

    public override DeepInfraCredentialProvider Read(
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
        DeepInfraCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepInfraCredentialProvider ReadAsPropertyName(
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
        DeepInfraCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
