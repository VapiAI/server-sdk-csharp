using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SlackOAuth2AuthorizationCredentialProvider>))]
public enum SlackOAuth2AuthorizationCredentialProvider
{
    [EnumMember(Value = "slack.oauth2-authorization")]
    SlackOauth2Authorization,
}
