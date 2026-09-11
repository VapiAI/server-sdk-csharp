using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateWebhookCredentialDtoProviderSerializer))]
public enum UpdateWebhookCredentialDtoProvider
{
    [EnumMember(Value = "webhook")]
    Webhook,
}

internal class UpdateWebhookCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateWebhookCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateWebhookCredentialDtoProvider
    > _stringToEnum = new() { { "webhook", UpdateWebhookCredentialDtoProvider.Webhook } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateWebhookCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateWebhookCredentialDtoProvider.Webhook, "webhook" } };

    public override UpdateWebhookCredentialDtoProvider Read(
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
        UpdateWebhookCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateWebhookCredentialDtoProvider ReadAsPropertyName(
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
        UpdateWebhookCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
