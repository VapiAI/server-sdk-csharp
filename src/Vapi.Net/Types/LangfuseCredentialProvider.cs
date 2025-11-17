using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LangfuseCredentialProvider>))]
public enum LangfuseCredentialProvider
{
    [EnumMember(Value = "langfuse")]
    Langfuse,
}
