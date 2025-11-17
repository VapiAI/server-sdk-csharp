using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TavusVoiceVoiceIdZero>))]
public enum TavusVoiceVoiceIdZero
{
    [EnumMember(Value = "r52da2535a")]
    R52Da2535A,
}
