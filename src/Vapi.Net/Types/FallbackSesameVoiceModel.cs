using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackSesameVoiceModel>))]
public enum FallbackSesameVoiceModel
{
    [EnumMember(Value = "csm-1b")]
    Csm1B,
}
