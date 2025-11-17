using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<KnowledgeBaseProvider>))]
public enum KnowledgeBaseProvider
{
    [EnumMember(Value = "google")]
    Google,
}
