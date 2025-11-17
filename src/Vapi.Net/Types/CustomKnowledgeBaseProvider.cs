using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CustomKnowledgeBaseProvider>))]
public enum CustomKnowledgeBaseProvider
{
    [EnumMember(Value = "custom-knowledge-base")]
    CustomKnowledgeBase,
}
