using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SmallestAiVoiceIdEnumSerializer))]
public enum SmallestAiVoiceIdEnum
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

internal class SmallestAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SmallestAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SmallestAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "emily", SmallestAiVoiceIdEnum.Emily },
        { "jasmine", SmallestAiVoiceIdEnum.Jasmine },
        { "arman", SmallestAiVoiceIdEnum.Arman },
        { "james", SmallestAiVoiceIdEnum.James },
        { "mithali", SmallestAiVoiceIdEnum.Mithali },
        { "aravind", SmallestAiVoiceIdEnum.Aravind },
        { "raj", SmallestAiVoiceIdEnum.Raj },
        { "diya", SmallestAiVoiceIdEnum.Diya },
        { "raman", SmallestAiVoiceIdEnum.Raman },
        { "ananya", SmallestAiVoiceIdEnum.Ananya },
        { "isha", SmallestAiVoiceIdEnum.Isha },
        { "william", SmallestAiVoiceIdEnum.William },
        { "aarav", SmallestAiVoiceIdEnum.Aarav },
        { "monika", SmallestAiVoiceIdEnum.Monika },
        { "niharika", SmallestAiVoiceIdEnum.Niharika },
        { "deepika", SmallestAiVoiceIdEnum.Deepika },
        { "raghav", SmallestAiVoiceIdEnum.Raghav },
        { "kajal", SmallestAiVoiceIdEnum.Kajal },
        { "radhika", SmallestAiVoiceIdEnum.Radhika },
        { "mansi", SmallestAiVoiceIdEnum.Mansi },
        { "nisha", SmallestAiVoiceIdEnum.Nisha },
        { "saurabh", SmallestAiVoiceIdEnum.Saurabh },
        { "pooja", SmallestAiVoiceIdEnum.Pooja },
        { "saina", SmallestAiVoiceIdEnum.Saina },
        { "sanya", SmallestAiVoiceIdEnum.Sanya },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SmallestAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { SmallestAiVoiceIdEnum.Emily, "emily" },
        { SmallestAiVoiceIdEnum.Jasmine, "jasmine" },
        { SmallestAiVoiceIdEnum.Arman, "arman" },
        { SmallestAiVoiceIdEnum.James, "james" },
        { SmallestAiVoiceIdEnum.Mithali, "mithali" },
        { SmallestAiVoiceIdEnum.Aravind, "aravind" },
        { SmallestAiVoiceIdEnum.Raj, "raj" },
        { SmallestAiVoiceIdEnum.Diya, "diya" },
        { SmallestAiVoiceIdEnum.Raman, "raman" },
        { SmallestAiVoiceIdEnum.Ananya, "ananya" },
        { SmallestAiVoiceIdEnum.Isha, "isha" },
        { SmallestAiVoiceIdEnum.William, "william" },
        { SmallestAiVoiceIdEnum.Aarav, "aarav" },
        { SmallestAiVoiceIdEnum.Monika, "monika" },
        { SmallestAiVoiceIdEnum.Niharika, "niharika" },
        { SmallestAiVoiceIdEnum.Deepika, "deepika" },
        { SmallestAiVoiceIdEnum.Raghav, "raghav" },
        { SmallestAiVoiceIdEnum.Kajal, "kajal" },
        { SmallestAiVoiceIdEnum.Radhika, "radhika" },
        { SmallestAiVoiceIdEnum.Mansi, "mansi" },
        { SmallestAiVoiceIdEnum.Nisha, "nisha" },
        { SmallestAiVoiceIdEnum.Saurabh, "saurabh" },
        { SmallestAiVoiceIdEnum.Pooja, "pooja" },
        { SmallestAiVoiceIdEnum.Saina, "saina" },
        { SmallestAiVoiceIdEnum.Sanya, "sanya" },
    };

    public override SmallestAiVoiceIdEnum Read(
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
        SmallestAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SmallestAiVoiceIdEnum ReadAsPropertyName(
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
        SmallestAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
