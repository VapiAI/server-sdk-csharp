using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SmallestAiCredentialProvider>))]
public enum SmallestAiCredentialProvider
{
    [EnumMember(Value = "smallest-ai")]
    SmallestAi,
}
