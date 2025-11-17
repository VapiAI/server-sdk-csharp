using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageKnowledgeBaseRequestType>))]
public enum ServerMessageKnowledgeBaseRequestType
{
    [EnumMember(Value = "knowledge-base-request")]
    KnowledgeBaseRequest,
}
