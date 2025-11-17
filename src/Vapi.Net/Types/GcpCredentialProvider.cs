using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GcpCredentialProvider>))]
public enum GcpCredentialProvider
{
    [EnumMember(Value = "gcp")]
    Gcp,
}
