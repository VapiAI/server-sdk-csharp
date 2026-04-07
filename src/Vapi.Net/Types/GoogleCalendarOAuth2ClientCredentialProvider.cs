using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleCalendarOAuth2ClientCredentialProviderSerializer))]
public enum GoogleCalendarOAuth2ClientCredentialProvider
{
    [EnumMember(Value = "google.calendar.oauth2-client")]
    GoogleCalendarOauth2Client,
}

internal class GoogleCalendarOAuth2ClientCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleCalendarOAuth2ClientCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleCalendarOAuth2ClientCredentialProvider
    > _stringToEnum = new()
    {
        {
            "google.calendar.oauth2-client",
            GoogleCalendarOAuth2ClientCredentialProvider.GoogleCalendarOauth2Client
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleCalendarOAuth2ClientCredentialProvider,
        string
    > _enumToString = new()
    {
        {
            GoogleCalendarOAuth2ClientCredentialProvider.GoogleCalendarOauth2Client,
            "google.calendar.oauth2-client"
        },
    };

    public override GoogleCalendarOAuth2ClientCredentialProvider Read(
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
        GoogleCalendarOAuth2ClientCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleCalendarOAuth2ClientCredentialProvider ReadAsPropertyName(
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
        GoogleCalendarOAuth2ClientCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
