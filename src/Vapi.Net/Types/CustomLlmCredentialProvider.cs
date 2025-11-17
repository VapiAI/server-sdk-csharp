using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CustomLlmCredentialProvider>))]
public enum CustomLlmCredentialProvider
{
    [EnumMember(Value = "custom-llm")]
    CustomLlm,
}
