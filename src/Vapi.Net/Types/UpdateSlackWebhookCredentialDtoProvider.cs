using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateSlackWebhookCredentialDtoProviderSerializer))]
public enum UpdateSlackWebhookCredentialDtoProvider
{
    [EnumMember(Value = "slack-webhook")]
    SlackWebhook,
}

internal class UpdateSlackWebhookCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateSlackWebhookCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateSlackWebhookCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "slack-webhook", UpdateSlackWebhookCredentialDtoProvider.SlackWebhook },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateSlackWebhookCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateSlackWebhookCredentialDtoProvider.SlackWebhook, "slack-webhook" },
    };

    public override UpdateSlackWebhookCredentialDtoProvider Read(
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
        UpdateSlackWebhookCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateSlackWebhookCredentialDtoProvider ReadAsPropertyName(
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
        UpdateSlackWebhookCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
