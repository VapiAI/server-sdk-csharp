using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TrieveKnowledgeBaseSearchPlanSearchType>))]
public enum TrieveKnowledgeBaseSearchPlanSearchType
{
    [EnumMember(Value = "fulltext")]
    Fulltext,

    [EnumMember(Value = "semantic")]
    Semantic,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "bm25")]
    Bm25,
}
