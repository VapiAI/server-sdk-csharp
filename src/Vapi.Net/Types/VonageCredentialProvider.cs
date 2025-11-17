using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VonageCredentialProvider>))]
public enum VonageCredentialProvider
{
    [EnumMember(Value = "vonage")]
    Vonage,
}
