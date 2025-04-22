using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<DeepgramVoiceId>))]
public enum DeepgramVoiceId
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

    [EnumMember(Value = "thalia")]
    Thalia,

    [EnumMember(Value = "andromeda")]
    Andromeda,

    [EnumMember(Value = "helena")]
    Helena,

    [EnumMember(Value = "apollo")]
    Apollo,

    [EnumMember(Value = "aries")]
    Aries,

    [EnumMember(Value = "amalthea")]
    Amalthea,

    [EnumMember(Value = "atlas")]
    Atlas,

    [EnumMember(Value = "aurora")]
    Aurora,

    [EnumMember(Value = "callista")]
    Callista,

    [EnumMember(Value = "cora")]
    Cora,

    [EnumMember(Value = "cordelia")]
    Cordelia,

    [EnumMember(Value = "delia")]
    Delia,

    [EnumMember(Value = "draco")]
    Draco,

    [EnumMember(Value = "electra")]
    Electra,

    [EnumMember(Value = "harmonia")]
    Harmonia,

    [EnumMember(Value = "hermes")]
    Hermes,

    [EnumMember(Value = "hyperion")]
    Hyperion,

    [EnumMember(Value = "iris")]
    Iris,

    [EnumMember(Value = "janus")]
    Janus,

    [EnumMember(Value = "juno")]
    Juno,

    [EnumMember(Value = "jupiter")]
    Jupiter,

    [EnumMember(Value = "mars")]
    Mars,

    [EnumMember(Value = "minerva")]
    Minerva,

    [EnumMember(Value = "neptune")]
    Neptune,

    [EnumMember(Value = "odysseus")]
    Odysseus,

    [EnumMember(Value = "ophelia")]
    Ophelia,

    [EnumMember(Value = "pandora")]
    Pandora,

    [EnumMember(Value = "phoebe")]
    Phoebe,

    [EnumMember(Value = "pluto")]
    Pluto,

    [EnumMember(Value = "saturn")]
    Saturn,

    [EnumMember(Value = "selene")]
    Selene,

    [EnumMember(Value = "theia")]
    Theia,

    [EnumMember(Value = "vesta")]
    Vesta,
}
