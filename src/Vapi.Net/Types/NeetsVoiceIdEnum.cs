using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<NeetsVoiceIdEnum>))]
public enum NeetsVoiceIdEnum
{
    [EnumMember(Value = "vits")]
    Vits,
}
