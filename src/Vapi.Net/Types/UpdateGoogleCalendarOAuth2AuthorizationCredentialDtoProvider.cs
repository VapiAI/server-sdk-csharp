using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProviderSerializer))]
public enum UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider
{
    [EnumMember(Value = "google.calendar.oauth2-authorization")]
    GoogleCalendarOauth2Authorization,
}

internal class UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider
    > _stringToEnum = new()
    {
        {
            "google.calendar.oauth2-authorization",
            UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider.GoogleCalendarOauth2Authorization
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        {
            UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider.GoogleCalendarOauth2Authorization,
            "google.calendar.oauth2-authorization"
        },
    };

    public override UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider Read(
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
        UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider ReadAsPropertyName(
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
        UpdateGoogleCalendarOAuth2AuthorizationCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
