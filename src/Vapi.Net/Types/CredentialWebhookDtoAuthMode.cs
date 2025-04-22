using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CredentialWebhookDtoAuthMode>))]
public enum CredentialWebhookDtoAuthMode
{
    [EnumMember(Value = "OAUTH2")]
    Oauth2,

    [EnumMember(Value = "API_KEY")]
    ApiKey,

    [EnumMember(Value = "BASIC")]
    Basic,
}
