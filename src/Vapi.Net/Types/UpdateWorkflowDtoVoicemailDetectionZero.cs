using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateWorkflowDtoVoicemailDetectionZero>))]
public enum UpdateWorkflowDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
