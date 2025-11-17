using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<WebhookCredentialProvider>))]
public enum WebhookCredentialProvider
{
    [EnumMember(Value = "webhook")]
    Webhook,
}
