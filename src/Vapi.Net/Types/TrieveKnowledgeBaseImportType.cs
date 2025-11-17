using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TrieveKnowledgeBaseImportType>))]
public enum TrieveKnowledgeBaseImportType
{
    [EnumMember(Value = "import")]
    Import,
}
