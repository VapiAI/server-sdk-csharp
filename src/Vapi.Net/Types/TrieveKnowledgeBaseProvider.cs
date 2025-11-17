using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TrieveKnowledgeBaseProvider>))]
public enum TrieveKnowledgeBaseProvider
{
    [EnumMember(Value = "trieve")]
    Trieve,
}
