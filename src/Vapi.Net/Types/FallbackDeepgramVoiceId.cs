using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackDeepgramVoiceIdSerializer))]
public enum FallbackDeepgramVoiceId
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
}

internal class FallbackDeepgramVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackDeepgramVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackDeepgramVoiceId
    > _stringToEnum = new()
    {
        { "asteria", FallbackDeepgramVoiceId.Asteria },
        { "luna", FallbackDeepgramVoiceId.Luna },
        { "stella", FallbackDeepgramVoiceId.Stella },
        { "athena", FallbackDeepgramVoiceId.Athena },
        { "hera", FallbackDeepgramVoiceId.Hera },
        { "orion", FallbackDeepgramVoiceId.Orion },
        { "arcas", FallbackDeepgramVoiceId.Arcas },
        { "perseus", FallbackDeepgramVoiceId.Perseus },
        { "angus", FallbackDeepgramVoiceId.Angus },
        { "orpheus", FallbackDeepgramVoiceId.Orpheus },
        { "helios", FallbackDeepgramVoiceId.Helios },
        { "zeus", FallbackDeepgramVoiceId.Zeus },
        { "thalia", FallbackDeepgramVoiceId.Thalia },
        { "andromeda", FallbackDeepgramVoiceId.Andromeda },
        { "helena", FallbackDeepgramVoiceId.Helena },
        { "apollo", FallbackDeepgramVoiceId.Apollo },
        { "aries", FallbackDeepgramVoiceId.Aries },
        { "amalthea", FallbackDeepgramVoiceId.Amalthea },
        { "atlas", FallbackDeepgramVoiceId.Atlas },
        { "aurora", FallbackDeepgramVoiceId.Aurora },
        { "callista", FallbackDeepgramVoiceId.Callista },
        { "cora", FallbackDeepgramVoiceId.Cora },
        { "cordelia", FallbackDeepgramVoiceId.Cordelia },
        { "delia", FallbackDeepgramVoiceId.Delia },
        { "draco", FallbackDeepgramVoiceId.Draco },
        { "electra", FallbackDeepgramVoiceId.Electra },
        { "harmonia", FallbackDeepgramVoiceId.Harmonia },
        { "hermes", FallbackDeepgramVoiceId.Hermes },
        { "hyperion", FallbackDeepgramVoiceId.Hyperion },
        { "iris", FallbackDeepgramVoiceId.Iris },
        { "janus", FallbackDeepgramVoiceId.Janus },
        { "juno", FallbackDeepgramVoiceId.Juno },
        { "jupiter", FallbackDeepgramVoiceId.Jupiter },
        { "mars", FallbackDeepgramVoiceId.Mars },
        { "minerva", FallbackDeepgramVoiceId.Minerva },
        { "neptune", FallbackDeepgramVoiceId.Neptune },
        { "odysseus", FallbackDeepgramVoiceId.Odysseus },
        { "ophelia", FallbackDeepgramVoiceId.Ophelia },
        { "pandora", FallbackDeepgramVoiceId.Pandora },
        { "phoebe", FallbackDeepgramVoiceId.Phoebe },
        { "pluto", FallbackDeepgramVoiceId.Pluto },
        { "saturn", FallbackDeepgramVoiceId.Saturn },
        { "selene", FallbackDeepgramVoiceId.Selene },
        { "theia", FallbackDeepgramVoiceId.Theia },
        { "vesta", FallbackDeepgramVoiceId.Vesta },
        { "celeste", FallbackDeepgramVoiceId.Celeste },
        { "estrella", FallbackDeepgramVoiceId.Estrella },
        { "nestor", FallbackDeepgramVoiceId.Nestor },
        { "sirio", FallbackDeepgramVoiceId.Sirio },
        { "carina", FallbackDeepgramVoiceId.Carina },
        { "alvaro", FallbackDeepgramVoiceId.Alvaro },
        { "diana", FallbackDeepgramVoiceId.Diana },
        { "aquila", FallbackDeepgramVoiceId.Aquila },
        { "selena", FallbackDeepgramVoiceId.Selena },
        { "javier", FallbackDeepgramVoiceId.Javier },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackDeepgramVoiceId,
        string
    > _enumToString = new()
    {
        { FallbackDeepgramVoiceId.Asteria, "asteria" },
        { FallbackDeepgramVoiceId.Luna, "luna" },
        { FallbackDeepgramVoiceId.Stella, "stella" },
        { FallbackDeepgramVoiceId.Athena, "athena" },
        { FallbackDeepgramVoiceId.Hera, "hera" },
        { FallbackDeepgramVoiceId.Orion, "orion" },
        { FallbackDeepgramVoiceId.Arcas, "arcas" },
        { FallbackDeepgramVoiceId.Perseus, "perseus" },
        { FallbackDeepgramVoiceId.Angus, "angus" },
        { FallbackDeepgramVoiceId.Orpheus, "orpheus" },
        { FallbackDeepgramVoiceId.Helios, "helios" },
        { FallbackDeepgramVoiceId.Zeus, "zeus" },
        { FallbackDeepgramVoiceId.Thalia, "thalia" },
        { FallbackDeepgramVoiceId.Andromeda, "andromeda" },
        { FallbackDeepgramVoiceId.Helena, "helena" },
        { FallbackDeepgramVoiceId.Apollo, "apollo" },
        { FallbackDeepgramVoiceId.Aries, "aries" },
        { FallbackDeepgramVoiceId.Amalthea, "amalthea" },
        { FallbackDeepgramVoiceId.Atlas, "atlas" },
        { FallbackDeepgramVoiceId.Aurora, "aurora" },
        { FallbackDeepgramVoiceId.Callista, "callista" },
        { FallbackDeepgramVoiceId.Cora, "cora" },
        { FallbackDeepgramVoiceId.Cordelia, "cordelia" },
        { FallbackDeepgramVoiceId.Delia, "delia" },
        { FallbackDeepgramVoiceId.Draco, "draco" },
        { FallbackDeepgramVoiceId.Electra, "electra" },
        { FallbackDeepgramVoiceId.Harmonia, "harmonia" },
        { FallbackDeepgramVoiceId.Hermes, "hermes" },
        { FallbackDeepgramVoiceId.Hyperion, "hyperion" },
        { FallbackDeepgramVoiceId.Iris, "iris" },
        { FallbackDeepgramVoiceId.Janus, "janus" },
        { FallbackDeepgramVoiceId.Juno, "juno" },
        { FallbackDeepgramVoiceId.Jupiter, "jupiter" },
        { FallbackDeepgramVoiceId.Mars, "mars" },
        { FallbackDeepgramVoiceId.Minerva, "minerva" },
        { FallbackDeepgramVoiceId.Neptune, "neptune" },
        { FallbackDeepgramVoiceId.Odysseus, "odysseus" },
        { FallbackDeepgramVoiceId.Ophelia, "ophelia" },
        { FallbackDeepgramVoiceId.Pandora, "pandora" },
        { FallbackDeepgramVoiceId.Phoebe, "phoebe" },
        { FallbackDeepgramVoiceId.Pluto, "pluto" },
        { FallbackDeepgramVoiceId.Saturn, "saturn" },
        { FallbackDeepgramVoiceId.Selene, "selene" },
        { FallbackDeepgramVoiceId.Theia, "theia" },
        { FallbackDeepgramVoiceId.Vesta, "vesta" },
        { FallbackDeepgramVoiceId.Celeste, "celeste" },
        { FallbackDeepgramVoiceId.Estrella, "estrella" },
        { FallbackDeepgramVoiceId.Nestor, "nestor" },
        { FallbackDeepgramVoiceId.Sirio, "sirio" },
        { FallbackDeepgramVoiceId.Carina, "carina" },
        { FallbackDeepgramVoiceId.Alvaro, "alvaro" },
        { FallbackDeepgramVoiceId.Diana, "diana" },
        { FallbackDeepgramVoiceId.Aquila, "aquila" },
        { FallbackDeepgramVoiceId.Selena, "selena" },
        { FallbackDeepgramVoiceId.Javier, "javier" },
    };

    public override FallbackDeepgramVoiceId Read(
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
        FallbackDeepgramVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackDeepgramVoiceId ReadAsPropertyName(
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
        FallbackDeepgramVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
