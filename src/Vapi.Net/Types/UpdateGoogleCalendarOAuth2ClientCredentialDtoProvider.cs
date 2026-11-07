using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateGoogleCalendarOAuth2ClientCredentialDtoProviderSerializer))]
public enum UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider
{
    [EnumMember(Value = "google.calendar.oauth2-client")]
    GoogleCalendarOauth2Client,
}

internal class UpdateGoogleCalendarOAuth2ClientCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider
    > _stringToEnum = new()
    {
        {
            "google.calendar.oauth2-client",
            UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider.GoogleCalendarOauth2Client
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        {
            UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider.GoogleCalendarOauth2Client,
            "google.calendar.oauth2-client"
        },
    };

    public override UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider Read(
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
        UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider ReadAsPropertyName(
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
        UpdateGoogleCalendarOAuth2ClientCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
