using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<RimeAiVoiceIdEnum>))]
public enum RimeAiVoiceIdEnum
{
    [EnumMember(Value = "abbie")]
    Abbie,

    [EnumMember(Value = "allison")]
    Allison,

    [EnumMember(Value = "ally")]
    Ally,

    [EnumMember(Value = "alona")]
    Alona,

    [EnumMember(Value = "amber")]
    Amber,

    [EnumMember(Value = "ana")]
    Ana,

    [EnumMember(Value = "antoine")]
    Antoine,

    [EnumMember(Value = "armon")]
    Armon,

    [EnumMember(Value = "brenda")]
    Brenda,

    [EnumMember(Value = "brittany")]
    Brittany,

    [EnumMember(Value = "carol")]
    Carol,

    [EnumMember(Value = "colin")]
    Colin,

    [EnumMember(Value = "courtney")]
    Courtney,

    [EnumMember(Value = "elena")]
    Elena,

    [EnumMember(Value = "elliot")]
    Elliot,

    [EnumMember(Value = "eva")]
    Eva,

    [EnumMember(Value = "geoff")]
    Geoff,

    [EnumMember(Value = "gerald")]
    Gerald,

    [EnumMember(Value = "hank")]
    Hank,

    [EnumMember(Value = "helen")]
    Helen,

    [EnumMember(Value = "hera")]
    Hera,

    [EnumMember(Value = "jen")]
    Jen,

    [EnumMember(Value = "joe")]
    Joe,

    [EnumMember(Value = "joy")]
    Joy,

    [EnumMember(Value = "juan")]
    Juan,

    [EnumMember(Value = "kendra")]
    Kendra,

    [EnumMember(Value = "kendrick")]
    Kendrick,

    [EnumMember(Value = "kenneth")]
    Kenneth,

    [EnumMember(Value = "kevin")]
    Kevin,

    [EnumMember(Value = "kris")]
    Kris,

    [EnumMember(Value = "linda")]
    Linda,

    [EnumMember(Value = "madison")]
    Madison,

    [EnumMember(Value = "marge")]
    Marge,

    [EnumMember(Value = "marina")]
    Marina,

    [EnumMember(Value = "marissa")]
    Marissa,

    [EnumMember(Value = "marta")]
    Marta,

    [EnumMember(Value = "maya")]
    Maya,

    [EnumMember(Value = "nicholas")]
    Nicholas,

    [EnumMember(Value = "nyles")]
    Nyles,

    [EnumMember(Value = "phil")]
    Phil,

    [EnumMember(Value = "reba")]
    Reba,

    [EnumMember(Value = "rex")]
    Rex,

    [EnumMember(Value = "rick")]
    Rick,

    [EnumMember(Value = "ritu")]
    Ritu,

    [EnumMember(Value = "rob")]
    Rob,

    [EnumMember(Value = "rodney")]
    Rodney,

    [EnumMember(Value = "rohan")]
    Rohan,

    [EnumMember(Value = "rosco")]
    Rosco,

    [EnumMember(Value = "samantha")]
    Samantha,

    [EnumMember(Value = "sandy")]
    Sandy,

    [EnumMember(Value = "selena")]
    Selena,

    [EnumMember(Value = "seth")]
    Seth,

    [EnumMember(Value = "sharon")]
    Sharon,

    [EnumMember(Value = "stan")]
    Stan,

    [EnumMember(Value = "tamra")]
    Tamra,

    [EnumMember(Value = "tanya")]
    Tanya,

    [EnumMember(Value = "tibur")]
    Tibur,

    [EnumMember(Value = "tj")]
    Tj,

    [EnumMember(Value = "tyler")]
    Tyler,

    [EnumMember(Value = "viv")]
    Viv,

    [EnumMember(Value = "yadira")]
    Yadira,

    [EnumMember(Value = "marsh")]
    Marsh,

    [EnumMember(Value = "bayou")]
    Bayou,

    [EnumMember(Value = "creek")]
    Creek,

    [EnumMember(Value = "brook")]
    Brook,

    [EnumMember(Value = "flower")]
    Flower,

    [EnumMember(Value = "spore")]
    Spore,

    [EnumMember(Value = "glacier")]
    Glacier,

    [EnumMember(Value = "gulch")]
    Gulch,

    [EnumMember(Value = "alpine")]
    Alpine,

    [EnumMember(Value = "cove")]
    Cove,

    [EnumMember(Value = "lagoon")]
    Lagoon,

    [EnumMember(Value = "tundra")]
    Tundra,

    [EnumMember(Value = "steppe")]
    Steppe,

    [EnumMember(Value = "mesa")]
    Mesa,

    [EnumMember(Value = "grove")]
    Grove,

    [EnumMember(Value = "rainforest")]
    Rainforest,

    [EnumMember(Value = "moraine")]
    Moraine,

    [EnumMember(Value = "wildflower")]
    Wildflower,

    [EnumMember(Value = "peak")]
    Peak,

    [EnumMember(Value = "boulder")]
    Boulder,

    [EnumMember(Value = "gypsum")]
    Gypsum,

    [EnumMember(Value = "zest")]
    Zest,

    [EnumMember(Value = "luna")]
    Luna,

    [EnumMember(Value = "celeste")]
    Celeste,

    [EnumMember(Value = "orion")]
    Orion,

    [EnumMember(Value = "ursa")]
    Ursa,

    [EnumMember(Value = "astra")]
    Astra,

    [EnumMember(Value = "esther")]
    Esther,

    [EnumMember(Value = "estelle")]
    Estelle,

    [EnumMember(Value = "andromeda")]
    Andromeda,
}
