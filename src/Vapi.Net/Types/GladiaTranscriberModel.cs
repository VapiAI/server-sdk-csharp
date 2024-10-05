using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<GladiaTranscriberModel>))]
public enum GladiaTranscriberModel
{
    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "accurate")]
    Accurate,
}