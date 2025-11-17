using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<WorkflowVoicemailDetectionZero>))]
public enum WorkflowVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
