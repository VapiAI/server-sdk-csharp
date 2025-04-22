using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CredentialSessionDtoProvider>))]
public enum CredentialSessionDtoProvider
{
    [EnumMember(Value = "google.calendar.oauth2-client")]
    GoogleCalendarOauth2Client,

    [EnumMember(Value = "google.calendar.oauth2-authorization")]
    GoogleCalendarOauth2Authorization,

    [EnumMember(Value = "google.sheets.oauth2-authorization")]
    GoogleSheetsOauth2Authorization,

    [EnumMember(Value = "slack.oauth2-authorization")]
    SlackOauth2Authorization,
}
