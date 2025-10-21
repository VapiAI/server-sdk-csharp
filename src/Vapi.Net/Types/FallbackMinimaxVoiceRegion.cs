using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackMinimaxVoiceRegion>))]
public enum FallbackMinimaxVoiceRegion
{
    [EnumMember(Value = "worldwide")]
    Worldwide,

    [EnumMember(Value = "china")]
    China,
}
