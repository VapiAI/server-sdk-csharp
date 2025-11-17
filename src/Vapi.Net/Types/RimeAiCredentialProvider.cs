using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<RimeAiCredentialProvider>))]
public enum RimeAiCredentialProvider
{
    [EnumMember(Value = "rime-ai")]
    RimeAi,
}
