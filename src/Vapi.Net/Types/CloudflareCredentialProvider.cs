using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CloudflareCredentialProvider>))]
public enum CloudflareCredentialProvider
{
    [EnumMember(Value = "cloudflare")]
    Cloudflare,
}
