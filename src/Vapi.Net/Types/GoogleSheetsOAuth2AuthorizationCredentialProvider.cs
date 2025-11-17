using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleSheetsOAuth2AuthorizationCredentialProvider>))]
public enum GoogleSheetsOAuth2AuthorizationCredentialProvider
{
    [EnumMember(Value = "google.sheets.oauth2-authorization")]
    GoogleSheetsOauth2Authorization,
}
