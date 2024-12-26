using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackDeepgramVoiceIdEnum>))]
public enum FallbackDeepgramVoiceIdEnum
{
    [EnumMember(Value = "asteria")]
    Asteria,

    [EnumMember(Value = "luna")]
    Luna,

    [EnumMember(Value = "stella")]
    Stella,

    [EnumMember(Value = "athena")]
    Athena,

    [EnumMember(Value = "hera")]
    Hera,

    [EnumMember(Value = "orion")]
    Orion,

    [EnumMember(Value = "arcas")]
    Arcas,

    [EnumMember(Value = "perseus")]
    Perseus,

    [EnumMember(Value = "angus")]
    Angus,

    [EnumMember(Value = "orpheus")]
    Orpheus,

    [EnumMember(Value = "helios")]
    Helios,

    [EnumMember(Value = "zeus")]
    Zeus,
}