using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateLangfuseCredentialDtoProviderSerializer))]
public enum UpdateLangfuseCredentialDtoProvider
{
    [EnumMember(Value = "langfuse")]
    Langfuse,
}

internal class UpdateLangfuseCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateLangfuseCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateLangfuseCredentialDtoProvider
    > _stringToEnum = new() { { "langfuse", UpdateLangfuseCredentialDtoProvider.Langfuse } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateLangfuseCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateLangfuseCredentialDtoProvider.Langfuse, "langfuse" } };

    public override UpdateLangfuseCredentialDtoProvider Read(
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
        UpdateLangfuseCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateLangfuseCredentialDtoProvider ReadAsPropertyName(
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
        UpdateLangfuseCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
