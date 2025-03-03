using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssistantOverridesBackgroundSound>))]
public enum AssistantOverridesBackgroundSound
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}
