using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepgramVoiceIdSerializer))]
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

    [EnumMember(Value = "celeste")]
    Celeste,

    [EnumMember(Value = "estrella")]
    Estrella,

    [EnumMember(Value = "nestor")]
    Nestor,

    [EnumMember(Value = "sirio")]
    Sirio,

    [EnumMember(Value = "carina")]
    Carina,

    [EnumMember(Value = "alvaro")]
    Alvaro,

    [EnumMember(Value = "diana")]
    Diana,

    [EnumMember(Value = "aquila")]
    Aquila,

    [EnumMember(Value = "selena")]
    Selena,

    [EnumMember(Value = "javier")]
    Javier,

    [EnumMember(Value = "viktoria")]
    Viktoria,

    [EnumMember(Value = "kara")]
    Kara,

    [EnumMember(Value = "fabian")]
    Fabian,

    [EnumMember(Value = "julius")]
    Julius,

    [EnumMember(Value = "lara")]
    Lara,

    [EnumMember(Value = "elara")]
    Elara,

    [EnumMember(Value = "aurelia")]
    Aurelia,

    [EnumMember(Value = "hannah")]
    Hannah,

    [EnumMember(Value = "kit")]
    Kit,

    [EnumMember(Value = "alexis")]
    Alexis,

    [EnumMember(Value = "cliff")]
    Cliff,

    [EnumMember(Value = "sienna")]
    Sienna,

    [EnumMember(Value = "cole")]
    Cole,

    [EnumMember(Value = "brooke")]
    Brooke,

    [EnumMember(Value = "colin")]
    Colin,

    [EnumMember(Value = "gemma")]
    Gemma,

    [EnumMember(Value = "haley")]
    Haley,

    [EnumMember(Value = "heather")]
    Heather,

    [EnumMember(Value = "miles")]
    Miles,

    [EnumMember(Value = "sean")]
    Sean,

    [EnumMember(Value = "bree")]
    Bree,

    [EnumMember(Value = "brittany")]
    Brittany,

    [EnumMember(Value = "bruce")]
    Bruce,

    [EnumMember(Value = "conor")]
    Conor,

    [EnumMember(Value = "donovan")]
    Donovan,

    [EnumMember(Value = "drew")]
    Drew,

    [EnumMember(Value = "elise")]
    Elise,

    [EnumMember(Value = "jack")]
    Jack,

    [EnumMember(Value = "kai")]
    Kai,

    [EnumMember(Value = "kelsey")]
    Kelsey,

    [EnumMember(Value = "maeve")]
    Maeve,

    [EnumMember(Value = "marcelo")]
    Marcelo,

    [EnumMember(Value = "marcus")]
    Marcus,

    [EnumMember(Value = "meena")]
    Meena,

    [EnumMember(Value = "meghan")]
    Meghan,

    [EnumMember(Value = "naveen")]
    Naveen,

    [EnumMember(Value = "paige")]
    Paige,

    [EnumMember(Value = "priya")]
    Priya,

    [EnumMember(Value = "rufus")]
    Rufus,

    [EnumMember(Value = "sharon")]
    Sharon,

    [EnumMember(Value = "tanner")]
    Tanner,

    [EnumMember(Value = "wade")]
    Wade,

    [EnumMember(Value = "wes")]
    Wes,
}

internal class DeepgramVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepgramVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepgramVoiceId
    > _stringToEnum = new()
    {
        { "asteria", DeepgramVoiceId.Asteria },
        { "luna", DeepgramVoiceId.Luna },
        { "stella", DeepgramVoiceId.Stella },
        { "athena", DeepgramVoiceId.Athena },
        { "hera", DeepgramVoiceId.Hera },
        { "orion", DeepgramVoiceId.Orion },
        { "arcas", DeepgramVoiceId.Arcas },
        { "perseus", DeepgramVoiceId.Perseus },
        { "angus", DeepgramVoiceId.Angus },
        { "orpheus", DeepgramVoiceId.Orpheus },
        { "helios", DeepgramVoiceId.Helios },
        { "zeus", DeepgramVoiceId.Zeus },
        { "thalia", DeepgramVoiceId.Thalia },
        { "andromeda", DeepgramVoiceId.Andromeda },
        { "helena", DeepgramVoiceId.Helena },
        { "apollo", DeepgramVoiceId.Apollo },
        { "aries", DeepgramVoiceId.Aries },
        { "amalthea", DeepgramVoiceId.Amalthea },
        { "atlas", DeepgramVoiceId.Atlas },
        { "aurora", DeepgramVoiceId.Aurora },
        { "callista", DeepgramVoiceId.Callista },
        { "cora", DeepgramVoiceId.Cora },
        { "cordelia", DeepgramVoiceId.Cordelia },
        { "delia", DeepgramVoiceId.Delia },
        { "draco", DeepgramVoiceId.Draco },
        { "electra", DeepgramVoiceId.Electra },
        { "harmonia", DeepgramVoiceId.Harmonia },
        { "hermes", DeepgramVoiceId.Hermes },
        { "hyperion", DeepgramVoiceId.Hyperion },
        { "iris", DeepgramVoiceId.Iris },
        { "janus", DeepgramVoiceId.Janus },
        { "juno", DeepgramVoiceId.Juno },
        { "jupiter", DeepgramVoiceId.Jupiter },
        { "mars", DeepgramVoiceId.Mars },
        { "minerva", DeepgramVoiceId.Minerva },
        { "neptune", DeepgramVoiceId.Neptune },
        { "odysseus", DeepgramVoiceId.Odysseus },
        { "ophelia", DeepgramVoiceId.Ophelia },
        { "pandora", DeepgramVoiceId.Pandora },
        { "phoebe", DeepgramVoiceId.Phoebe },
        { "pluto", DeepgramVoiceId.Pluto },
        { "saturn", DeepgramVoiceId.Saturn },
        { "selene", DeepgramVoiceId.Selene },
        { "theia", DeepgramVoiceId.Theia },
        { "vesta", DeepgramVoiceId.Vesta },
        { "celeste", DeepgramVoiceId.Celeste },
        { "estrella", DeepgramVoiceId.Estrella },
        { "nestor", DeepgramVoiceId.Nestor },
        { "sirio", DeepgramVoiceId.Sirio },
        { "carina", DeepgramVoiceId.Carina },
        { "alvaro", DeepgramVoiceId.Alvaro },
        { "diana", DeepgramVoiceId.Diana },
        { "aquila", DeepgramVoiceId.Aquila },
        { "selena", DeepgramVoiceId.Selena },
        { "javier", DeepgramVoiceId.Javier },
        { "viktoria", DeepgramVoiceId.Viktoria },
        { "kara", DeepgramVoiceId.Kara },
        { "fabian", DeepgramVoiceId.Fabian },
        { "julius", DeepgramVoiceId.Julius },
        { "lara", DeepgramVoiceId.Lara },
        { "elara", DeepgramVoiceId.Elara },
        { "aurelia", DeepgramVoiceId.Aurelia },
        { "hannah", DeepgramVoiceId.Hannah },
        { "kit", DeepgramVoiceId.Kit },
        { "alexis", DeepgramVoiceId.Alexis },
        { "cliff", DeepgramVoiceId.Cliff },
        { "sienna", DeepgramVoiceId.Sienna },
        { "cole", DeepgramVoiceId.Cole },
        { "brooke", DeepgramVoiceId.Brooke },
        { "colin", DeepgramVoiceId.Colin },
        { "gemma", DeepgramVoiceId.Gemma },
        { "haley", DeepgramVoiceId.Haley },
        { "heather", DeepgramVoiceId.Heather },
        { "miles", DeepgramVoiceId.Miles },
        { "sean", DeepgramVoiceId.Sean },
        { "bree", DeepgramVoiceId.Bree },
        { "brittany", DeepgramVoiceId.Brittany },
        { "bruce", DeepgramVoiceId.Bruce },
        { "conor", DeepgramVoiceId.Conor },
        { "donovan", DeepgramVoiceId.Donovan },
        { "drew", DeepgramVoiceId.Drew },
        { "elise", DeepgramVoiceId.Elise },
        { "jack", DeepgramVoiceId.Jack },
        { "kai", DeepgramVoiceId.Kai },
        { "kelsey", DeepgramVoiceId.Kelsey },
        { "maeve", DeepgramVoiceId.Maeve },
        { "marcelo", DeepgramVoiceId.Marcelo },
        { "marcus", DeepgramVoiceId.Marcus },
        { "meena", DeepgramVoiceId.Meena },
        { "meghan", DeepgramVoiceId.Meghan },
        { "naveen", DeepgramVoiceId.Naveen },
        { "paige", DeepgramVoiceId.Paige },
        { "priya", DeepgramVoiceId.Priya },
        { "rufus", DeepgramVoiceId.Rufus },
        { "sharon", DeepgramVoiceId.Sharon },
        { "tanner", DeepgramVoiceId.Tanner },
        { "wade", DeepgramVoiceId.Wade },
        { "wes", DeepgramVoiceId.Wes },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepgramVoiceId,
        string
    > _enumToString = new()
    {
        { DeepgramVoiceId.Asteria, "asteria" },
        { DeepgramVoiceId.Luna, "luna" },
        { DeepgramVoiceId.Stella, "stella" },
        { DeepgramVoiceId.Athena, "athena" },
        { DeepgramVoiceId.Hera, "hera" },
        { DeepgramVoiceId.Orion, "orion" },
        { DeepgramVoiceId.Arcas, "arcas" },
        { DeepgramVoiceId.Perseus, "perseus" },
        { DeepgramVoiceId.Angus, "angus" },
        { DeepgramVoiceId.Orpheus, "orpheus" },
        { DeepgramVoiceId.Helios, "helios" },
        { DeepgramVoiceId.Zeus, "zeus" },
        { DeepgramVoiceId.Thalia, "thalia" },
        { DeepgramVoiceId.Andromeda, "andromeda" },
        { DeepgramVoiceId.Helena, "helena" },
        { DeepgramVoiceId.Apollo, "apollo" },
        { DeepgramVoiceId.Aries, "aries" },
        { DeepgramVoiceId.Amalthea, "amalthea" },
        { DeepgramVoiceId.Atlas, "atlas" },
        { DeepgramVoiceId.Aurora, "aurora" },
        { DeepgramVoiceId.Callista, "callista" },
        { DeepgramVoiceId.Cora, "cora" },
        { DeepgramVoiceId.Cordelia, "cordelia" },
        { DeepgramVoiceId.Delia, "delia" },
        { DeepgramVoiceId.Draco, "draco" },
        { DeepgramVoiceId.Electra, "electra" },
        { DeepgramVoiceId.Harmonia, "harmonia" },
        { DeepgramVoiceId.Hermes, "hermes" },
        { DeepgramVoiceId.Hyperion, "hyperion" },
        { DeepgramVoiceId.Iris, "iris" },
        { DeepgramVoiceId.Janus, "janus" },
        { DeepgramVoiceId.Juno, "juno" },
        { DeepgramVoiceId.Jupiter, "jupiter" },
        { DeepgramVoiceId.Mars, "mars" },
        { DeepgramVoiceId.Minerva, "minerva" },
        { DeepgramVoiceId.Neptune, "neptune" },
        { DeepgramVoiceId.Odysseus, "odysseus" },
        { DeepgramVoiceId.Ophelia, "ophelia" },
        { DeepgramVoiceId.Pandora, "pandora" },
        { DeepgramVoiceId.Phoebe, "phoebe" },
        { DeepgramVoiceId.Pluto, "pluto" },
        { DeepgramVoiceId.Saturn, "saturn" },
        { DeepgramVoiceId.Selene, "selene" },
        { DeepgramVoiceId.Theia, "theia" },
        { DeepgramVoiceId.Vesta, "vesta" },
        { DeepgramVoiceId.Celeste, "celeste" },
        { DeepgramVoiceId.Estrella, "estrella" },
        { DeepgramVoiceId.Nestor, "nestor" },
        { DeepgramVoiceId.Sirio, "sirio" },
        { DeepgramVoiceId.Carina, "carina" },
        { DeepgramVoiceId.Alvaro, "alvaro" },
        { DeepgramVoiceId.Diana, "diana" },
        { DeepgramVoiceId.Aquila, "aquila" },
        { DeepgramVoiceId.Selena, "selena" },
        { DeepgramVoiceId.Javier, "javier" },
        { DeepgramVoiceId.Viktoria, "viktoria" },
        { DeepgramVoiceId.Kara, "kara" },
        { DeepgramVoiceId.Fabian, "fabian" },
        { DeepgramVoiceId.Julius, "julius" },
        { DeepgramVoiceId.Lara, "lara" },
        { DeepgramVoiceId.Elara, "elara" },
        { DeepgramVoiceId.Aurelia, "aurelia" },
        { DeepgramVoiceId.Hannah, "hannah" },
        { DeepgramVoiceId.Kit, "kit" },
        { DeepgramVoiceId.Alexis, "alexis" },
        { DeepgramVoiceId.Cliff, "cliff" },
        { DeepgramVoiceId.Sienna, "sienna" },
        { DeepgramVoiceId.Cole, "cole" },
        { DeepgramVoiceId.Brooke, "brooke" },
        { DeepgramVoiceId.Colin, "colin" },
        { DeepgramVoiceId.Gemma, "gemma" },
        { DeepgramVoiceId.Haley, "haley" },
        { DeepgramVoiceId.Heather, "heather" },
        { DeepgramVoiceId.Miles, "miles" },
        { DeepgramVoiceId.Sean, "sean" },
        { DeepgramVoiceId.Bree, "bree" },
        { DeepgramVoiceId.Brittany, "brittany" },
        { DeepgramVoiceId.Bruce, "bruce" },
        { DeepgramVoiceId.Conor, "conor" },
        { DeepgramVoiceId.Donovan, "donovan" },
        { DeepgramVoiceId.Drew, "drew" },
        { DeepgramVoiceId.Elise, "elise" },
        { DeepgramVoiceId.Jack, "jack" },
        { DeepgramVoiceId.Kai, "kai" },
        { DeepgramVoiceId.Kelsey, "kelsey" },
        { DeepgramVoiceId.Maeve, "maeve" },
        { DeepgramVoiceId.Marcelo, "marcelo" },
        { DeepgramVoiceId.Marcus, "marcus" },
        { DeepgramVoiceId.Meena, "meena" },
        { DeepgramVoiceId.Meghan, "meghan" },
        { DeepgramVoiceId.Naveen, "naveen" },
        { DeepgramVoiceId.Paige, "paige" },
        { DeepgramVoiceId.Priya, "priya" },
        { DeepgramVoiceId.Rufus, "rufus" },
        { DeepgramVoiceId.Sharon, "sharon" },
        { DeepgramVoiceId.Tanner, "tanner" },
        { DeepgramVoiceId.Wade, "wade" },
        { DeepgramVoiceId.Wes, "wes" },
    };

    public override DeepgramVoiceId Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        DeepgramVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepgramVoiceId ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        DeepgramVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
