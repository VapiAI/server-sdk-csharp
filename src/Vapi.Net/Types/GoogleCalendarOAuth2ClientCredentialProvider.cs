using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleCalendarOAuth2ClientCredentialProvider>))]
public enum GoogleCalendarOAuth2ClientCredentialProvider
{
    [EnumMember(Value = "google.calendar.oauth2-client")]
    GoogleCalendarOauth2Client,
}
