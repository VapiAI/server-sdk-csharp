using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateInflectionAiCredentialDtoProviderSerializer))]
public enum UpdateInflectionAiCredentialDtoProvider
{
    [EnumMember(Value = "inflection-ai")]
    InflectionAi,
}

internal class UpdateInflectionAiCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateInflectionAiCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateInflectionAiCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "inflection-ai", UpdateInflectionAiCredentialDtoProvider.InflectionAi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateInflectionAiCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateInflectionAiCredentialDtoProvider.InflectionAi, "inflection-ai" },
    };

    public override UpdateInflectionAiCredentialDtoProvider Read(
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
        UpdateInflectionAiCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateInflectionAiCredentialDtoProvider ReadAsPropertyName(
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
        UpdateInflectionAiCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
