using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<WorkflowUserEditableVoicemailDetectionZero>))]
public enum WorkflowUserEditableVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
