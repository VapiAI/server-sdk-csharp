using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateAssistantDtoVoicemailDetectionZero>))]
public enum CreateAssistantDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
