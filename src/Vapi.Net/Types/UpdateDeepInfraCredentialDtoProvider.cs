using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateDeepInfraCredentialDtoProviderSerializer))]
public enum UpdateDeepInfraCredentialDtoProvider
{
    [EnumMember(Value = "deepinfra")]
    Deepinfra,
}

internal class UpdateDeepInfraCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateDeepInfraCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateDeepInfraCredentialDtoProvider
    > _stringToEnum = new() { { "deepinfra", UpdateDeepInfraCredentialDtoProvider.Deepinfra } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateDeepInfraCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateDeepInfraCredentialDtoProvider.Deepinfra, "deepinfra" } };

    public override UpdateDeepInfraCredentialDtoProvider Read(
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
        UpdateDeepInfraCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateDeepInfraCredentialDtoProvider ReadAsPropertyName(
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
        UpdateDeepInfraCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
