using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CredentialWebhookDtoOperation>))]
public enum CredentialWebhookDtoOperation
{
    [EnumMember(Value = "creation")]
    Creation,

    [EnumMember(Value = "override")]
    Override,

    [EnumMember(Value = "refresh")]
    Refresh,
}
