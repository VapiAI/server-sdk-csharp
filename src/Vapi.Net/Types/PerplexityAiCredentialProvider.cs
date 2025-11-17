using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PerplexityAiCredentialProvider>))]
public enum PerplexityAiCredentialProvider
{
    [EnumMember(Value = "perplexity-ai")]
    PerplexityAi,
}
