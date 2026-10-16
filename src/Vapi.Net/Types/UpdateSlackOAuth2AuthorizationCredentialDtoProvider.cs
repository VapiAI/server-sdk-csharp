using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateSlackOAuth2AuthorizationCredentialDtoProviderSerializer))]
public enum UpdateSlackOAuth2AuthorizationCredentialDtoProvider
{
    [EnumMember(Value = "slack.oauth2-authorization")]
    SlackOauth2Authorization,
}

internal class UpdateSlackOAuth2AuthorizationCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateSlackOAuth2AuthorizationCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateSlackOAuth2AuthorizationCredentialDtoProvider
    > _stringToEnum = new()
    {
        {
            "slack.oauth2-authorization",
            UpdateSlackOAuth2AuthorizationCredentialDtoProvider.SlackOauth2Authorization
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateSlackOAuth2AuthorizationCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        {
            UpdateSlackOAuth2AuthorizationCredentialDtoProvider.SlackOauth2Authorization,
            "slack.oauth2-authorization"
        },
    };

    public override UpdateSlackOAuth2AuthorizationCredentialDtoProvider Read(
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
        UpdateSlackOAuth2AuthorizationCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateSlackOAuth2AuthorizationCredentialDtoProvider ReadAsPropertyName(
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
        UpdateSlackOAuth2AuthorizationCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
