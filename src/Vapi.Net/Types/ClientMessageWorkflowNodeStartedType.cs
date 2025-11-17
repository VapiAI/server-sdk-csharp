using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageWorkflowNodeStartedType>))]
public enum ClientMessageWorkflowNodeStartedType
{
    [EnumMember(Value = "workflow.node.started")]
    WorkflowNodeStarted,
}
