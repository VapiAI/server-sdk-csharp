using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<MistralCredentialProvider>))]
public enum MistralCredentialProvider
{
    [EnumMember(Value = "mistral")]
    Mistral,
}
