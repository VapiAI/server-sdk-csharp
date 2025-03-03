using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CartesiaExperimentalControlsSpeed>))]
public enum CartesiaExperimentalControlsSpeed
{
    [EnumMember(Value = "slowest")]
    Slowest,

    [EnumMember(Value = "slow")]
    Slow,

    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "fastest")]
    Fastest,
}
