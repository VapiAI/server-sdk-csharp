using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSmallestAiVoiceIdEnumSerializer))]
public enum FallbackSmallestAiVoiceIdEnum
{
    [EnumMember(Value = "emily")]
    Emily,

    [EnumMember(Value = "jasmine")]
    Jasmine,

    [EnumMember(Value = "arman")]
    Arman,

    [EnumMember(Value = "james")]
    James,

    [EnumMember(Value = "mithali")]
    Mithali,

    [EnumMember(Value = "aravind")]
    Aravind,

    [EnumMember(Value = "raj")]
    Raj,

    [EnumMember(Value = "diya")]
    Diya,

    [EnumMember(Value = "raman")]
    Raman,

    [EnumMember(Value = "ananya")]
    Ananya,

    [EnumMember(Value = "isha")]
    Isha,

    [EnumMember(Value = "william")]
    William,

    [EnumMember(Value = "aarav")]
    Aarav,

    [EnumMember(Value = "monika")]
    Monika,

    [EnumMember(Value = "niharika")]
    Niharika,

    [EnumMember(Value = "deepika")]
    Deepika,

    [EnumMember(Value = "raghav")]
    Raghav,

    [EnumMember(Value = "kajal")]
    Kajal,

    [EnumMember(Value = "radhika")]
    Radhika,

    [EnumMember(Value = "mansi")]
    Mansi,

    [EnumMember(Value = "nisha")]
    Nisha,

    [EnumMember(Value = "saurabh")]
    Saurabh,

    [EnumMember(Value = "pooja")]
    Pooja,

    [EnumMember(Value = "saina")]
    Saina,

    [EnumMember(Value = "sanya")]
    Sanya,
}

internal class FallbackSmallestAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSmallestAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSmallestAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "emily", FallbackSmallestAiVoiceIdEnum.Emily },
        { "jasmine", FallbackSmallestAiVoiceIdEnum.Jasmine },
        { "arman", FallbackSmallestAiVoiceIdEnum.Arman },
        { "james", FallbackSmallestAiVoiceIdEnum.James },
        { "mithali", FallbackSmallestAiVoiceIdEnum.Mithali },
        { "aravind", FallbackSmallestAiVoiceIdEnum.Aravind },
        { "raj", FallbackSmallestAiVoiceIdEnum.Raj },
        { "diya", FallbackSmallestAiVoiceIdEnum.Diya },
        { "raman", FallbackSmallestAiVoiceIdEnum.Raman },
        { "ananya", FallbackSmallestAiVoiceIdEnum.Ananya },
        { "isha", FallbackSmallestAiVoiceIdEnum.Isha },
        { "william", FallbackSmallestAiVoiceIdEnum.William },
        { "aarav", FallbackSmallestAiVoiceIdEnum.Aarav },
        { "monika", FallbackSmallestAiVoiceIdEnum.Monika },
        { "niharika", FallbackSmallestAiVoiceIdEnum.Niharika },
        { "deepika", FallbackSmallestAiVoiceIdEnum.Deepika },
        { "raghav", FallbackSmallestAiVoiceIdEnum.Raghav },
        { "kajal", FallbackSmallestAiVoiceIdEnum.Kajal },
        { "radhika", FallbackSmallestAiVoiceIdEnum.Radhika },
        { "mansi", FallbackSmallestAiVoiceIdEnum.Mansi },
        { "nisha", FallbackSmallestAiVoiceIdEnum.Nisha },
        { "saurabh", FallbackSmallestAiVoiceIdEnum.Saurabh },
        { "pooja", FallbackSmallestAiVoiceIdEnum.Pooja },
        { "saina", FallbackSmallestAiVoiceIdEnum.Saina },
        { "sanya", FallbackSmallestAiVoiceIdEnum.Sanya },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSmallestAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { FallbackSmallestAiVoiceIdEnum.Emily, "emily" },
        { FallbackSmallestAiVoiceIdEnum.Jasmine, "jasmine" },
        { FallbackSmallestAiVoiceIdEnum.Arman, "arman" },
        { FallbackSmallestAiVoiceIdEnum.James, "james" },
        { FallbackSmallestAiVoiceIdEnum.Mithali, "mithali" },
        { FallbackSmallestAiVoiceIdEnum.Aravind, "aravind" },
        { FallbackSmallestAiVoiceIdEnum.Raj, "raj" },
        { FallbackSmallestAiVoiceIdEnum.Diya, "diya" },
        { FallbackSmallestAiVoiceIdEnum.Raman, "raman" },
        { FallbackSmallestAiVoiceIdEnum.Ananya, "ananya" },
        { FallbackSmallestAiVoiceIdEnum.Isha, "isha" },
        { FallbackSmallestAiVoiceIdEnum.William, "william" },
        { FallbackSmallestAiVoiceIdEnum.Aarav, "aarav" },
        { FallbackSmallestAiVoiceIdEnum.Monika, "monika" },
        { FallbackSmallestAiVoiceIdEnum.Niharika, "niharika" },
        { FallbackSmallestAiVoiceIdEnum.Deepika, "deepika" },
        { FallbackSmallestAiVoiceIdEnum.Raghav, "raghav" },
        { FallbackSmallestAiVoiceIdEnum.Kajal, "kajal" },
        { FallbackSmallestAiVoiceIdEnum.Radhika, "radhika" },
        { FallbackSmallestAiVoiceIdEnum.Mansi, "mansi" },
        { FallbackSmallestAiVoiceIdEnum.Nisha, "nisha" },
        { FallbackSmallestAiVoiceIdEnum.Saurabh, "saurabh" },
        { FallbackSmallestAiVoiceIdEnum.Pooja, "pooja" },
        { FallbackSmallestAiVoiceIdEnum.Saina, "saina" },
        { FallbackSmallestAiVoiceIdEnum.Sanya, "sanya" },
    };

    public override FallbackSmallestAiVoiceIdEnum Read(
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
        FallbackSmallestAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSmallestAiVoiceIdEnum ReadAsPropertyName(
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
        FallbackSmallestAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
