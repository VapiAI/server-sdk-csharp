using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RimeAiVoiceIdEnumSerializer))]
public enum RimeAiVoiceIdEnum
{
    [EnumMember(Value = "cove")]
    Cove,

    [EnumMember(Value = "moon")]
    Moon,

    [EnumMember(Value = "wildflower")]
    Wildflower,

    [EnumMember(Value = "eva")]
    Eva,

    [EnumMember(Value = "amber")]
    Amber,

    [EnumMember(Value = "maya")]
    Maya,

    [EnumMember(Value = "lagoon")]
    Lagoon,

    [EnumMember(Value = "breeze")]
    Breeze,

    [EnumMember(Value = "helen")]
    Helen,

    [EnumMember(Value = "joy")]
    Joy,

    [EnumMember(Value = "marsh")]
    Marsh,

    [EnumMember(Value = "creek")]
    Creek,

    [EnumMember(Value = "cedar")]
    Cedar,

    [EnumMember(Value = "alpine")]
    Alpine,

    [EnumMember(Value = "summit")]
    Summit,

    [EnumMember(Value = "nicholas")]
    Nicholas,

    [EnumMember(Value = "tyler")]
    Tyler,

    [EnumMember(Value = "colin")]
    Colin,

    [EnumMember(Value = "hank")]
    Hank,

    [EnumMember(Value = "thunder")]
    Thunder,

    [EnumMember(Value = "astra")]
    Astra,

    [EnumMember(Value = "eucalyptus")]
    Eucalyptus,

    [EnumMember(Value = "moraine")]
    Moraine,

    [EnumMember(Value = "peak")]
    Peak,

    [EnumMember(Value = "tundra")]
    Tundra,

    [EnumMember(Value = "mesa_extra")]
    MesaExtra,

    [EnumMember(Value = "talon")]
    Talon,

    [EnumMember(Value = "marlu")]
    Marlu,

    [EnumMember(Value = "glacier")]
    Glacier,

    [EnumMember(Value = "falcon")]
    Falcon,

    [EnumMember(Value = "luna")]
    Luna,

    [EnumMember(Value = "celeste")]
    Celeste,

    [EnumMember(Value = "estelle")]
    Estelle,

    [EnumMember(Value = "andromeda")]
    Andromeda,

    [EnumMember(Value = "esther")]
    Esther,

    [EnumMember(Value = "lyra")]
    Lyra,

    [EnumMember(Value = "lintel")]
    Lintel,

    [EnumMember(Value = "oculus")]
    Oculus,

    [EnumMember(Value = "vespera")]
    Vespera,

    [EnumMember(Value = "transom")]
    Transom,

    [EnumMember(Value = "bond")]
    Bond,

    [EnumMember(Value = "arcade")]
    Arcade,

    [EnumMember(Value = "atrium")]
    Atrium,

    [EnumMember(Value = "cupola")]
    Cupola,

    [EnumMember(Value = "fern")]
    Fern,

    [EnumMember(Value = "sirius")]
    Sirius,

    [EnumMember(Value = "orion")]
    Orion,

    [EnumMember(Value = "masonry")]
    Masonry,

    [EnumMember(Value = "albion")]
    Albion,

    [EnumMember(Value = "parapet")]
    Parapet,
}

internal class RimeAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RimeAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RimeAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "cove", RimeAiVoiceIdEnum.Cove },
        { "moon", RimeAiVoiceIdEnum.Moon },
        { "wildflower", RimeAiVoiceIdEnum.Wildflower },
        { "eva", RimeAiVoiceIdEnum.Eva },
        { "amber", RimeAiVoiceIdEnum.Amber },
        { "maya", RimeAiVoiceIdEnum.Maya },
        { "lagoon", RimeAiVoiceIdEnum.Lagoon },
        { "breeze", RimeAiVoiceIdEnum.Breeze },
        { "helen", RimeAiVoiceIdEnum.Helen },
        { "joy", RimeAiVoiceIdEnum.Joy },
        { "marsh", RimeAiVoiceIdEnum.Marsh },
        { "creek", RimeAiVoiceIdEnum.Creek },
        { "cedar", RimeAiVoiceIdEnum.Cedar },
        { "alpine", RimeAiVoiceIdEnum.Alpine },
        { "summit", RimeAiVoiceIdEnum.Summit },
        { "nicholas", RimeAiVoiceIdEnum.Nicholas },
        { "tyler", RimeAiVoiceIdEnum.Tyler },
        { "colin", RimeAiVoiceIdEnum.Colin },
        { "hank", RimeAiVoiceIdEnum.Hank },
        { "thunder", RimeAiVoiceIdEnum.Thunder },
        { "astra", RimeAiVoiceIdEnum.Astra },
        { "eucalyptus", RimeAiVoiceIdEnum.Eucalyptus },
        { "moraine", RimeAiVoiceIdEnum.Moraine },
        { "peak", RimeAiVoiceIdEnum.Peak },
        { "tundra", RimeAiVoiceIdEnum.Tundra },
        { "mesa_extra", RimeAiVoiceIdEnum.MesaExtra },
        { "talon", RimeAiVoiceIdEnum.Talon },
        { "marlu", RimeAiVoiceIdEnum.Marlu },
        { "glacier", RimeAiVoiceIdEnum.Glacier },
        { "falcon", RimeAiVoiceIdEnum.Falcon },
        { "luna", RimeAiVoiceIdEnum.Luna },
        { "celeste", RimeAiVoiceIdEnum.Celeste },
        { "estelle", RimeAiVoiceIdEnum.Estelle },
        { "andromeda", RimeAiVoiceIdEnum.Andromeda },
        { "esther", RimeAiVoiceIdEnum.Esther },
        { "lyra", RimeAiVoiceIdEnum.Lyra },
        { "lintel", RimeAiVoiceIdEnum.Lintel },
        { "oculus", RimeAiVoiceIdEnum.Oculus },
        { "vespera", RimeAiVoiceIdEnum.Vespera },
        { "transom", RimeAiVoiceIdEnum.Transom },
        { "bond", RimeAiVoiceIdEnum.Bond },
        { "arcade", RimeAiVoiceIdEnum.Arcade },
        { "atrium", RimeAiVoiceIdEnum.Atrium },
        { "cupola", RimeAiVoiceIdEnum.Cupola },
        { "fern", RimeAiVoiceIdEnum.Fern },
        { "sirius", RimeAiVoiceIdEnum.Sirius },
        { "orion", RimeAiVoiceIdEnum.Orion },
        { "masonry", RimeAiVoiceIdEnum.Masonry },
        { "albion", RimeAiVoiceIdEnum.Albion },
        { "parapet", RimeAiVoiceIdEnum.Parapet },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RimeAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { RimeAiVoiceIdEnum.Cove, "cove" },
        { RimeAiVoiceIdEnum.Moon, "moon" },
        { RimeAiVoiceIdEnum.Wildflower, "wildflower" },
        { RimeAiVoiceIdEnum.Eva, "eva" },
        { RimeAiVoiceIdEnum.Amber, "amber" },
        { RimeAiVoiceIdEnum.Maya, "maya" },
        { RimeAiVoiceIdEnum.Lagoon, "lagoon" },
        { RimeAiVoiceIdEnum.Breeze, "breeze" },
        { RimeAiVoiceIdEnum.Helen, "helen" },
        { RimeAiVoiceIdEnum.Joy, "joy" },
        { RimeAiVoiceIdEnum.Marsh, "marsh" },
        { RimeAiVoiceIdEnum.Creek, "creek" },
        { RimeAiVoiceIdEnum.Cedar, "cedar" },
        { RimeAiVoiceIdEnum.Alpine, "alpine" },
        { RimeAiVoiceIdEnum.Summit, "summit" },
        { RimeAiVoiceIdEnum.Nicholas, "nicholas" },
        { RimeAiVoiceIdEnum.Tyler, "tyler" },
        { RimeAiVoiceIdEnum.Colin, "colin" },
        { RimeAiVoiceIdEnum.Hank, "hank" },
        { RimeAiVoiceIdEnum.Thunder, "thunder" },
        { RimeAiVoiceIdEnum.Astra, "astra" },
        { RimeAiVoiceIdEnum.Eucalyptus, "eucalyptus" },
        { RimeAiVoiceIdEnum.Moraine, "moraine" },
        { RimeAiVoiceIdEnum.Peak, "peak" },
        { RimeAiVoiceIdEnum.Tundra, "tundra" },
        { RimeAiVoiceIdEnum.MesaExtra, "mesa_extra" },
        { RimeAiVoiceIdEnum.Talon, "talon" },
        { RimeAiVoiceIdEnum.Marlu, "marlu" },
        { RimeAiVoiceIdEnum.Glacier, "glacier" },
        { RimeAiVoiceIdEnum.Falcon, "falcon" },
        { RimeAiVoiceIdEnum.Luna, "luna" },
        { RimeAiVoiceIdEnum.Celeste, "celeste" },
        { RimeAiVoiceIdEnum.Estelle, "estelle" },
        { RimeAiVoiceIdEnum.Andromeda, "andromeda" },
        { RimeAiVoiceIdEnum.Esther, "esther" },
        { RimeAiVoiceIdEnum.Lyra, "lyra" },
        { RimeAiVoiceIdEnum.Lintel, "lintel" },
        { RimeAiVoiceIdEnum.Oculus, "oculus" },
        { RimeAiVoiceIdEnum.Vespera, "vespera" },
        { RimeAiVoiceIdEnum.Transom, "transom" },
        { RimeAiVoiceIdEnum.Bond, "bond" },
        { RimeAiVoiceIdEnum.Arcade, "arcade" },
        { RimeAiVoiceIdEnum.Atrium, "atrium" },
        { RimeAiVoiceIdEnum.Cupola, "cupola" },
        { RimeAiVoiceIdEnum.Fern, "fern" },
        { RimeAiVoiceIdEnum.Sirius, "sirius" },
        { RimeAiVoiceIdEnum.Orion, "orion" },
        { RimeAiVoiceIdEnum.Masonry, "masonry" },
        { RimeAiVoiceIdEnum.Albion, "albion" },
        { RimeAiVoiceIdEnum.Parapet, "parapet" },
    };

    public override RimeAiVoiceIdEnum Read(
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
        RimeAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RimeAiVoiceIdEnum ReadAsPropertyName(
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
        RimeAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
