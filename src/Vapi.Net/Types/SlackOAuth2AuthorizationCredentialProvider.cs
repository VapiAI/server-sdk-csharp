using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SlackOAuth2AuthorizationCredentialProviderSerializer))]
public enum SlackOAuth2AuthorizationCredentialProvider
{
    [EnumMember(Value = "slack.oauth2-authorization")]
    SlackOauth2Authorization,
}

internal class SlackOAuth2AuthorizationCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SlackOAuth2AuthorizationCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SlackOAuth2AuthorizationCredentialProvider
    > _stringToEnum = new()
    {
        {
            "slack.oauth2-authorization",
            SlackOAuth2AuthorizationCredentialProvider.SlackOauth2Authorization
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SlackOAuth2AuthorizationCredentialProvider,
        string
    > _enumToString = new()
    {
        {
            SlackOAuth2AuthorizationCredentialProvider.SlackOauth2Authorization,
            "slack.oauth2-authorization"
        },
    };

    public override SlackOAuth2AuthorizationCredentialProvider Read(
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
        SlackOAuth2AuthorizationCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SlackOAuth2AuthorizationCredentialProvider ReadAsPropertyName(
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
        SlackOAuth2AuthorizationCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
