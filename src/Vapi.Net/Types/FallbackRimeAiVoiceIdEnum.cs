using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackRimeAiVoiceIdEnumSerializer))]
public enum FallbackRimeAiVoiceIdEnum
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

internal class FallbackRimeAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackRimeAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackRimeAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "cove", FallbackRimeAiVoiceIdEnum.Cove },
        { "moon", FallbackRimeAiVoiceIdEnum.Moon },
        { "wildflower", FallbackRimeAiVoiceIdEnum.Wildflower },
        { "eva", FallbackRimeAiVoiceIdEnum.Eva },
        { "amber", FallbackRimeAiVoiceIdEnum.Amber },
        { "maya", FallbackRimeAiVoiceIdEnum.Maya },
        { "lagoon", FallbackRimeAiVoiceIdEnum.Lagoon },
        { "breeze", FallbackRimeAiVoiceIdEnum.Breeze },
        { "helen", FallbackRimeAiVoiceIdEnum.Helen },
        { "joy", FallbackRimeAiVoiceIdEnum.Joy },
        { "marsh", FallbackRimeAiVoiceIdEnum.Marsh },
        { "creek", FallbackRimeAiVoiceIdEnum.Creek },
        { "cedar", FallbackRimeAiVoiceIdEnum.Cedar },
        { "alpine", FallbackRimeAiVoiceIdEnum.Alpine },
        { "summit", FallbackRimeAiVoiceIdEnum.Summit },
        { "nicholas", FallbackRimeAiVoiceIdEnum.Nicholas },
        { "tyler", FallbackRimeAiVoiceIdEnum.Tyler },
        { "colin", FallbackRimeAiVoiceIdEnum.Colin },
        { "hank", FallbackRimeAiVoiceIdEnum.Hank },
        { "thunder", FallbackRimeAiVoiceIdEnum.Thunder },
        { "astra", FallbackRimeAiVoiceIdEnum.Astra },
        { "eucalyptus", FallbackRimeAiVoiceIdEnum.Eucalyptus },
        { "moraine", FallbackRimeAiVoiceIdEnum.Moraine },
        { "peak", FallbackRimeAiVoiceIdEnum.Peak },
        { "tundra", FallbackRimeAiVoiceIdEnum.Tundra },
        { "mesa_extra", FallbackRimeAiVoiceIdEnum.MesaExtra },
        { "talon", FallbackRimeAiVoiceIdEnum.Talon },
        { "marlu", FallbackRimeAiVoiceIdEnum.Marlu },
        { "glacier", FallbackRimeAiVoiceIdEnum.Glacier },
        { "falcon", FallbackRimeAiVoiceIdEnum.Falcon },
        { "luna", FallbackRimeAiVoiceIdEnum.Luna },
        { "celeste", FallbackRimeAiVoiceIdEnum.Celeste },
        { "estelle", FallbackRimeAiVoiceIdEnum.Estelle },
        { "andromeda", FallbackRimeAiVoiceIdEnum.Andromeda },
        { "esther", FallbackRimeAiVoiceIdEnum.Esther },
        { "lyra", FallbackRimeAiVoiceIdEnum.Lyra },
        { "lintel", FallbackRimeAiVoiceIdEnum.Lintel },
        { "oculus", FallbackRimeAiVoiceIdEnum.Oculus },
        { "vespera", FallbackRimeAiVoiceIdEnum.Vespera },
        { "transom", FallbackRimeAiVoiceIdEnum.Transom },
        { "bond", FallbackRimeAiVoiceIdEnum.Bond },
        { "arcade", FallbackRimeAiVoiceIdEnum.Arcade },
        { "atrium", FallbackRimeAiVoiceIdEnum.Atrium },
        { "cupola", FallbackRimeAiVoiceIdEnum.Cupola },
        { "fern", FallbackRimeAiVoiceIdEnum.Fern },
        { "sirius", FallbackRimeAiVoiceIdEnum.Sirius },
        { "orion", FallbackRimeAiVoiceIdEnum.Orion },
        { "masonry", FallbackRimeAiVoiceIdEnum.Masonry },
        { "albion", FallbackRimeAiVoiceIdEnum.Albion },
        { "parapet", FallbackRimeAiVoiceIdEnum.Parapet },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackRimeAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { FallbackRimeAiVoiceIdEnum.Cove, "cove" },
        { FallbackRimeAiVoiceIdEnum.Moon, "moon" },
        { FallbackRimeAiVoiceIdEnum.Wildflower, "wildflower" },
        { FallbackRimeAiVoiceIdEnum.Eva, "eva" },
        { FallbackRimeAiVoiceIdEnum.Amber, "amber" },
        { FallbackRimeAiVoiceIdEnum.Maya, "maya" },
        { FallbackRimeAiVoiceIdEnum.Lagoon, "lagoon" },
        { FallbackRimeAiVoiceIdEnum.Breeze, "breeze" },
        { FallbackRimeAiVoiceIdEnum.Helen, "helen" },
        { FallbackRimeAiVoiceIdEnum.Joy, "joy" },
        { FallbackRimeAiVoiceIdEnum.Marsh, "marsh" },
        { FallbackRimeAiVoiceIdEnum.Creek, "creek" },
        { FallbackRimeAiVoiceIdEnum.Cedar, "cedar" },
        { FallbackRimeAiVoiceIdEnum.Alpine, "alpine" },
        { FallbackRimeAiVoiceIdEnum.Summit, "summit" },
        { FallbackRimeAiVoiceIdEnum.Nicholas, "nicholas" },
        { FallbackRimeAiVoiceIdEnum.Tyler, "tyler" },
        { FallbackRimeAiVoiceIdEnum.Colin, "colin" },
        { FallbackRimeAiVoiceIdEnum.Hank, "hank" },
        { FallbackRimeAiVoiceIdEnum.Thunder, "thunder" },
        { FallbackRimeAiVoiceIdEnum.Astra, "astra" },
        { FallbackRimeAiVoiceIdEnum.Eucalyptus, "eucalyptus" },
        { FallbackRimeAiVoiceIdEnum.Moraine, "moraine" },
        { FallbackRimeAiVoiceIdEnum.Peak, "peak" },
        { FallbackRimeAiVoiceIdEnum.Tundra, "tundra" },
        { FallbackRimeAiVoiceIdEnum.MesaExtra, "mesa_extra" },
        { FallbackRimeAiVoiceIdEnum.Talon, "talon" },
        { FallbackRimeAiVoiceIdEnum.Marlu, "marlu" },
        { FallbackRimeAiVoiceIdEnum.Glacier, "glacier" },
        { FallbackRimeAiVoiceIdEnum.Falcon, "falcon" },
        { FallbackRimeAiVoiceIdEnum.Luna, "luna" },
        { FallbackRimeAiVoiceIdEnum.Celeste, "celeste" },
        { FallbackRimeAiVoiceIdEnum.Estelle, "estelle" },
        { FallbackRimeAiVoiceIdEnum.Andromeda, "andromeda" },
        { FallbackRimeAiVoiceIdEnum.Esther, "esther" },
        { FallbackRimeAiVoiceIdEnum.Lyra, "lyra" },
        { FallbackRimeAiVoiceIdEnum.Lintel, "lintel" },
        { FallbackRimeAiVoiceIdEnum.Oculus, "oculus" },
        { FallbackRimeAiVoiceIdEnum.Vespera, "vespera" },
        { FallbackRimeAiVoiceIdEnum.Transom, "transom" },
        { FallbackRimeAiVoiceIdEnum.Bond, "bond" },
        { FallbackRimeAiVoiceIdEnum.Arcade, "arcade" },
        { FallbackRimeAiVoiceIdEnum.Atrium, "atrium" },
        { FallbackRimeAiVoiceIdEnum.Cupola, "cupola" },
        { FallbackRimeAiVoiceIdEnum.Fern, "fern" },
        { FallbackRimeAiVoiceIdEnum.Sirius, "sirius" },
        { FallbackRimeAiVoiceIdEnum.Orion, "orion" },
        { FallbackRimeAiVoiceIdEnum.Masonry, "masonry" },
        { FallbackRimeAiVoiceIdEnum.Albion, "albion" },
        { FallbackRimeAiVoiceIdEnum.Parapet, "parapet" },
    };

    public override FallbackRimeAiVoiceIdEnum Read(
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
        FallbackRimeAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackRimeAiVoiceIdEnum ReadAsPropertyName(
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
        FallbackRimeAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
