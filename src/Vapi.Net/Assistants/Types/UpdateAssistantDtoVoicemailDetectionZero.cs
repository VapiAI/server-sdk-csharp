using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateAssistantDtoVoicemailDetectionZero>))]
public enum UpdateAssistantDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
