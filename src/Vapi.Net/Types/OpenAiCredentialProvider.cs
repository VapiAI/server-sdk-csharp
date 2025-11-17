using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiCredentialProvider>))]
public enum OpenAiCredentialProvider
{
    [EnumMember(Value = "openai")]
    Openai,
}
