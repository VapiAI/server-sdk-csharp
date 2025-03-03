using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<XaiModelModel>))]
public enum XaiModelModel
{
    [EnumMember(Value = "grok-beta")]
    GrokBeta,

    [EnumMember(Value = "grok-2")]
    Grok2,

    [EnumMember(Value = "grok-3")]
    Grok3,
}
