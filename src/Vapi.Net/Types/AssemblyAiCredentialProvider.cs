using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssemblyAiCredentialProvider>))]
public enum AssemblyAiCredentialProvider
{
    [EnumMember(Value = "assembly-ai")]
    AssemblyAi,
}
