using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackElevenLabsTranscriberModel>))]
public enum FallbackElevenLabsTranscriberModel
{
    [EnumMember(Value = "scribe_v1")]
    ScribeV1,
}
