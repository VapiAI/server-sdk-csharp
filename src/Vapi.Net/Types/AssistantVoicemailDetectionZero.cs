using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssistantVoicemailDetectionZero>))]
public enum AssistantVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}
