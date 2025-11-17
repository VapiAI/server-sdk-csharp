using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleCalendarOAuth2AuthorizationCredentialProvider>))]
public enum GoogleCalendarOAuth2AuthorizationCredentialProvider
{
    [EnumMember(Value = "google.calendar.oauth2-authorization")]
    GoogleCalendarOauth2Authorization,
}
