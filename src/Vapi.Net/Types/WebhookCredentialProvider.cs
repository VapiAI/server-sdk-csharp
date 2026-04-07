using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WebhookCredentialProviderSerializer))]
public enum WebhookCredentialProvider
{
    [EnumMember(Value = "webhook")]
    Webhook,
}

internal class WebhookCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WebhookCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WebhookCredentialProvider
    > _stringToEnum = new() { { "webhook", WebhookCredentialProvider.Webhook } };

    private static readonly global::System.Collections.Generic.Dictionary<
        WebhookCredentialProvider,
        string
    > _enumToString = new() { { WebhookCredentialProvider.Webhook, "webhook" } };

    public override WebhookCredentialProvider Read(
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
        WebhookCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WebhookCredentialProvider ReadAsPropertyName(
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
        WebhookCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
