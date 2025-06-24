using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GladiaTranscriberModel>))]
public enum GladiaTranscriberModel
{
    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "accurate")]
    Accurate,

    [EnumMember(Value = "solaria-1")]
    Solaria1,
}
