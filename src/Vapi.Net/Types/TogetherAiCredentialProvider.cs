using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TogetherAiCredentialProvider>))]
public enum TogetherAiCredentialProvider
{
    [EnumMember(Value = "together-ai")]
    TogetherAi,
}
