using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleCalendarOAuth2AuthorizationCredentialProviderSerializer))]
public enum GoogleCalendarOAuth2AuthorizationCredentialProvider
{
    [EnumMember(Value = "google.calendar.oauth2-authorization")]
    GoogleCalendarOauth2Authorization,
}

internal class GoogleCalendarOAuth2AuthorizationCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleCalendarOAuth2AuthorizationCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleCalendarOAuth2AuthorizationCredentialProvider
    > _stringToEnum = new()
    {
        {
            "google.calendar.oauth2-authorization",
            GoogleCalendarOAuth2AuthorizationCredentialProvider.GoogleCalendarOauth2Authorization
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleCalendarOAuth2AuthorizationCredentialProvider,
        string
    > _enumToString = new()
    {
        {
            GoogleCalendarOAuth2AuthorizationCredentialProvider.GoogleCalendarOauth2Authorization,
            "google.calendar.oauth2-authorization"
        },
    };

    public override GoogleCalendarOAuth2AuthorizationCredentialProvider Read(
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
        GoogleCalendarOAuth2AuthorizationCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleCalendarOAuth2AuthorizationCredentialProvider ReadAsPropertyName(
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
        GoogleCalendarOAuth2AuthorizationCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
