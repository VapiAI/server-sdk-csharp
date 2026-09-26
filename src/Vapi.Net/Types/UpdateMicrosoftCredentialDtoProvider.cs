using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateMicrosoftCredentialDtoProviderSerializer))]
public enum UpdateMicrosoftCredentialDtoProvider
{
    [EnumMember(Value = "microsoft")]
    Microsoft,
}

internal class UpdateMicrosoftCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateMicrosoftCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateMicrosoftCredentialDtoProvider
    > _stringToEnum = new() { { "microsoft", UpdateMicrosoftCredentialDtoProvider.Microsoft } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateMicrosoftCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateMicrosoftCredentialDtoProvider.Microsoft, "microsoft" } };

    public override UpdateMicrosoftCredentialDtoProvider Read(
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
        UpdateMicrosoftCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateMicrosoftCredentialDtoProvider ReadAsPropertyName(
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
        UpdateMicrosoftCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
