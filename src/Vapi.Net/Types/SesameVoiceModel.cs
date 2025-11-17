using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SesameVoiceModel>))]
public enum SesameVoiceModel
{
    [EnumMember(Value = "csm-1b")]
    Csm1B,
}
