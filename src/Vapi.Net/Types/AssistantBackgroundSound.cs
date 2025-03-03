using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssistantBackgroundSound>))]
public enum AssistantBackgroundSound
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "office")]
    Office,
}
