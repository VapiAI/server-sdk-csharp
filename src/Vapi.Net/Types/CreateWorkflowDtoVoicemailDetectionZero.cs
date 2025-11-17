using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateWorkflowDtoVoicemailDetectionZero>))]
public enum CreateWorkflowDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
