using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CredentialWebhookDtoType>))]
public enum CredentialWebhookDtoType
{
    [EnumMember(Value = "auth")]
    Auth,

    [EnumMember(Value = "sync")]
    Sync,

    [EnumMember(Value = "forward")]
    Forward,
}
