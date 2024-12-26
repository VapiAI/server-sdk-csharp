using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackNeetsVoiceIdEnum>))]
public enum FallbackNeetsVoiceIdEnum
{
    [EnumMember(Value = "vits")]
    Vits,
}
