using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMicrosoftVoiceVoiceIdSerializer))]
public enum FallbackMicrosoftVoiceVoiceId
{
    [EnumMember(Value = "de-DE-Klaus:MAI-Voice-2")]
    DeDeKlausMaiVoice2,

    [EnumMember(Value = "de-DE-Mia:MAI-Voice-2")]
    DeDeMiaMaiVoice2,

    [EnumMember(Value = "en-AU-Lisa:MAI-Voice-2")]
    EnAuLisaMaiVoice2,

    [EnumMember(Value = "en-US-Ethan:MAI-Voice-2")]
    EnUsEthanMaiVoice2,

    [EnumMember(Value = "en-US-Grant:MAI-Voice-2")]
    EnUsGrantMaiVoice2,

    [EnumMember(Value = "en-US-Harper:MAI-Voice-2")]
    EnUsHarperMaiVoice2,

    [EnumMember(Value = "en-US-Iris:MAI-Voice-2")]
    EnUsIrisMaiVoice2,

    [EnumMember(Value = "en-US-Jasper:MAI-Voice-2")]
    EnUsJasperMaiVoice2,

    [EnumMember(Value = "en-US-Olivia:MAI-Voice-2")]
    EnUsOliviaMaiVoice2,

    [EnumMember(Value = "es-ES-Marta:MAI-Voice-2")]
    EsEsMartaMaiVoice2,

    [EnumMember(Value = "es-MX-Alejo:MAI-Voice-2")]
    EsMxAlejoMaiVoice2,

    [EnumMember(Value = "es-MX-Valeria:MAI-Voice-2")]
    EsMxValeriaMaiVoice2,

    [EnumMember(Value = "fr-FR-Marc:MAI-Voice-2")]
    FrFrMarcMaiVoice2,

    [EnumMember(Value = "fr-FR-Soleil:MAI-Voice-2")]
    FrFrSoleilMaiVoice2,

    [EnumMember(Value = "hi-IN-Arjun:MAI-Voice-2")]
    HiInArjunMaiVoice2,

    [EnumMember(Value = "hi-IN-Dhruv:MAI-Voice-2")]
    HiInDhruvMaiVoice2,

    [EnumMember(Value = "hi-IN-Kavya:MAI-Voice-2")]
    HiInKavyaMaiVoice2,

    [EnumMember(Value = "hi-IN-Priya:MAI-Voice-2")]
    HiInPriyaMaiVoice2,

    [EnumMember(Value = "hu-HU-Bence:MAI-Voice-2")]
    HuHuBenceMaiVoice2,

    [EnumMember(Value = "hu-HU-Levente:MAI-Voice-2")]
    HuHuLeventeMaiVoice2,

    [EnumMember(Value = "hu-HU-Lilla:MAI-Voice-2")]
    HuHuLillaMaiVoice2,

    [EnumMember(Value = "hu-HU-Réka:MAI-Voice-2")]
    HuHuRekaMaiVoice2,

    [EnumMember(Value = "it-IT-Luca:MAI-Voice-2")]
    ItItLucaMaiVoice2,

    [EnumMember(Value = "it-IT-Rosa:MAI-Voice-2")]
    ItItRosaMaiVoice2,

    [EnumMember(Value = "ko-KR-Hana:MAI-Voice-2")]
    KoKrHanaMaiVoice2,

    [EnumMember(Value = "ko-KR-Junho:MAI-Voice-2")]
    KoKrJunhoMaiVoice2,

    [EnumMember(Value = "nl-NL-Fleur:MAI-Voice-2")]
    NlNlFleurMaiVoice2,

    [EnumMember(Value = "nl-NL-Sander:MAI-Voice-2")]
    NlNlSanderMaiVoice2,

    [EnumMember(Value = "pt-BR-Caio:MAI-Voice-2")]
    PtBrCaioMaiVoice2,

    [EnumMember(Value = "pt-BR-Luana:MAI-Voice-2")]
    PtBrLuanaMaiVoice2,

    [EnumMember(Value = "pt-BR-Pedro:MAI-Voice-2")]
    PtBrPedroMaiVoice2,

    [EnumMember(Value = "pt-BR-Rafael:MAI-Voice-2")]
    PtBrRafaelMaiVoice2,

    [EnumMember(Value = "pt-PT-Rui:MAI-Voice-2")]
    PtPtRuiMaiVoice2,

    [EnumMember(Value = "ro-RO-Andrei:MAI-Voice-2")]
    RoRoAndreiMaiVoice2,

    [EnumMember(Value = "ro-RO-Elena:MAI-Voice-2")]
    RoRoElenaMaiVoice2,

    [EnumMember(Value = "ro-RO-Ioana:MAI-Voice-2")]
    RoRoIoanaMaiVoice2,

    [EnumMember(Value = "ro-RO-Radu:MAI-Voice-2")]
    RoRoRaduMaiVoice2,

    [EnumMember(Value = "ru-RU-Lev:MAI-Voice-2")]
    RuRuLevMaiVoice2,

    [EnumMember(Value = "ru-RU-Masha:MAI-Voice-2")]
    RuRuMashaMaiVoice2,

    [EnumMember(Value = "th-TH-Krit:MAI-Voice-2")]
    ThThKritMaiVoice2,

    [EnumMember(Value = "th-TH-Nattapong:MAI-Voice-2")]
    ThThNattapongMaiVoice2,

    [EnumMember(Value = "tr-TR-Aydin:MAI-Voice-2")]
    TrTrAydinMaiVoice2,

    [EnumMember(Value = "tr-TR-Elif:MAI-Voice-2")]
    TrTrElifMaiVoice2,

    [EnumMember(Value = "zh-CN-Bo:MAI-Voice-2")]
    ZhCnBoMaiVoice2,

    [EnumMember(Value = "zh-CN-Lan:MAI-Voice-2")]
    ZhCnLanMaiVoice2,

    [EnumMember(Value = "zh-CN-Mei:MAI-Voice-2")]
    ZhCnMeiMaiVoice2,
}

internal class FallbackMicrosoftVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMicrosoftVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMicrosoftVoiceVoiceId
    > _stringToEnum = new()
    {
        { "de-DE-Klaus:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.DeDeKlausMaiVoice2 },
        { "de-DE-Mia:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.DeDeMiaMaiVoice2 },
        { "en-AU-Lisa:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnAuLisaMaiVoice2 },
        { "en-US-Ethan:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnUsEthanMaiVoice2 },
        { "en-US-Grant:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnUsGrantMaiVoice2 },
        { "en-US-Harper:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnUsHarperMaiVoice2 },
        { "en-US-Iris:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnUsIrisMaiVoice2 },
        { "en-US-Jasper:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnUsJasperMaiVoice2 },
        { "en-US-Olivia:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EnUsOliviaMaiVoice2 },
        { "es-ES-Marta:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EsEsMartaMaiVoice2 },
        { "es-MX-Alejo:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EsMxAlejoMaiVoice2 },
        { "es-MX-Valeria:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.EsMxValeriaMaiVoice2 },
        { "fr-FR-Marc:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.FrFrMarcMaiVoice2 },
        { "fr-FR-Soleil:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.FrFrSoleilMaiVoice2 },
        { "hi-IN-Arjun:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HiInArjunMaiVoice2 },
        { "hi-IN-Dhruv:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HiInDhruvMaiVoice2 },
        { "hi-IN-Kavya:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HiInKavyaMaiVoice2 },
        { "hi-IN-Priya:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HiInPriyaMaiVoice2 },
        { "hu-HU-Bence:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HuHuBenceMaiVoice2 },
        { "hu-HU-Levente:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HuHuLeventeMaiVoice2 },
        { "hu-HU-Lilla:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HuHuLillaMaiVoice2 },
        { "hu-HU-Réka:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.HuHuRekaMaiVoice2 },
        { "it-IT-Luca:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ItItLucaMaiVoice2 },
        { "it-IT-Rosa:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ItItRosaMaiVoice2 },
        { "ko-KR-Hana:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.KoKrHanaMaiVoice2 },
        { "ko-KR-Junho:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.KoKrJunhoMaiVoice2 },
        { "nl-NL-Fleur:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.NlNlFleurMaiVoice2 },
        { "nl-NL-Sander:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.NlNlSanderMaiVoice2 },
        { "pt-BR-Caio:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.PtBrCaioMaiVoice2 },
        { "pt-BR-Luana:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.PtBrLuanaMaiVoice2 },
        { "pt-BR-Pedro:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.PtBrPedroMaiVoice2 },
        { "pt-BR-Rafael:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.PtBrRafaelMaiVoice2 },
        { "pt-PT-Rui:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.PtPtRuiMaiVoice2 },
        { "ro-RO-Andrei:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.RoRoAndreiMaiVoice2 },
        { "ro-RO-Elena:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.RoRoElenaMaiVoice2 },
        { "ro-RO-Ioana:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.RoRoIoanaMaiVoice2 },
        { "ro-RO-Radu:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.RoRoRaduMaiVoice2 },
        { "ru-RU-Lev:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.RuRuLevMaiVoice2 },
        { "ru-RU-Masha:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.RuRuMashaMaiVoice2 },
        { "th-TH-Krit:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ThThKritMaiVoice2 },
        { "th-TH-Nattapong:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ThThNattapongMaiVoice2 },
        { "tr-TR-Aydin:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.TrTrAydinMaiVoice2 },
        { "tr-TR-Elif:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.TrTrElifMaiVoice2 },
        { "zh-CN-Bo:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ZhCnBoMaiVoice2 },
        { "zh-CN-Lan:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ZhCnLanMaiVoice2 },
        { "zh-CN-Mei:MAI-Voice-2", FallbackMicrosoftVoiceVoiceId.ZhCnMeiMaiVoice2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMicrosoftVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { FallbackMicrosoftVoiceVoiceId.DeDeKlausMaiVoice2, "de-DE-Klaus:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.DeDeMiaMaiVoice2, "de-DE-Mia:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnAuLisaMaiVoice2, "en-AU-Lisa:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnUsEthanMaiVoice2, "en-US-Ethan:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnUsGrantMaiVoice2, "en-US-Grant:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnUsHarperMaiVoice2, "en-US-Harper:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnUsIrisMaiVoice2, "en-US-Iris:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnUsJasperMaiVoice2, "en-US-Jasper:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EnUsOliviaMaiVoice2, "en-US-Olivia:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EsEsMartaMaiVoice2, "es-ES-Marta:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EsMxAlejoMaiVoice2, "es-MX-Alejo:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.EsMxValeriaMaiVoice2, "es-MX-Valeria:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.FrFrMarcMaiVoice2, "fr-FR-Marc:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.FrFrSoleilMaiVoice2, "fr-FR-Soleil:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HiInArjunMaiVoice2, "hi-IN-Arjun:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HiInDhruvMaiVoice2, "hi-IN-Dhruv:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HiInKavyaMaiVoice2, "hi-IN-Kavya:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HiInPriyaMaiVoice2, "hi-IN-Priya:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HuHuBenceMaiVoice2, "hu-HU-Bence:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HuHuLeventeMaiVoice2, "hu-HU-Levente:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HuHuLillaMaiVoice2, "hu-HU-Lilla:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.HuHuRekaMaiVoice2, "hu-HU-Réka:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ItItLucaMaiVoice2, "it-IT-Luca:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ItItRosaMaiVoice2, "it-IT-Rosa:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.KoKrHanaMaiVoice2, "ko-KR-Hana:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.KoKrJunhoMaiVoice2, "ko-KR-Junho:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.NlNlFleurMaiVoice2, "nl-NL-Fleur:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.NlNlSanderMaiVoice2, "nl-NL-Sander:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.PtBrCaioMaiVoice2, "pt-BR-Caio:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.PtBrLuanaMaiVoice2, "pt-BR-Luana:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.PtBrPedroMaiVoice2, "pt-BR-Pedro:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.PtBrRafaelMaiVoice2, "pt-BR-Rafael:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.PtPtRuiMaiVoice2, "pt-PT-Rui:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.RoRoAndreiMaiVoice2, "ro-RO-Andrei:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.RoRoElenaMaiVoice2, "ro-RO-Elena:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.RoRoIoanaMaiVoice2, "ro-RO-Ioana:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.RoRoRaduMaiVoice2, "ro-RO-Radu:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.RuRuLevMaiVoice2, "ru-RU-Lev:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.RuRuMashaMaiVoice2, "ru-RU-Masha:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ThThKritMaiVoice2, "th-TH-Krit:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ThThNattapongMaiVoice2, "th-TH-Nattapong:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.TrTrAydinMaiVoice2, "tr-TR-Aydin:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.TrTrElifMaiVoice2, "tr-TR-Elif:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ZhCnBoMaiVoice2, "zh-CN-Bo:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ZhCnLanMaiVoice2, "zh-CN-Lan:MAI-Voice-2" },
        { FallbackMicrosoftVoiceVoiceId.ZhCnMeiMaiVoice2, "zh-CN-Mei:MAI-Voice-2" },
    };

    public override FallbackMicrosoftVoiceVoiceId Read(
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
        FallbackMicrosoftVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMicrosoftVoiceVoiceId ReadAsPropertyName(
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
        FallbackMicrosoftVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
