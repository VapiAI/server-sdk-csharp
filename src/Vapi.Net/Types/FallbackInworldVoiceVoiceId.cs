using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackInworldVoiceVoiceIdSerializer))]
public enum FallbackInworldVoiceVoiceId
{
    [EnumMember(Value = "Alex")]
    Alex,

    [EnumMember(Value = "Ashley")]
    Ashley,

    [EnumMember(Value = "Craig")]
    Craig,

    [EnumMember(Value = "Deborah")]
    Deborah,

    [EnumMember(Value = "Dennis")]
    Dennis,

    [EnumMember(Value = "Edward")]
    Edward,

    [EnumMember(Value = "Elizabeth")]
    Elizabeth,

    [EnumMember(Value = "Hades")]
    Hades,

    [EnumMember(Value = "Julia")]
    Julia,

    [EnumMember(Value = "Pixie")]
    Pixie,

    [EnumMember(Value = "Mark")]
    Mark,

    [EnumMember(Value = "Olivia")]
    Olivia,

    [EnumMember(Value = "Priya")]
    Priya,

    [EnumMember(Value = "Ronald")]
    Ronald,

    [EnumMember(Value = "Sarah")]
    Sarah,

    [EnumMember(Value = "Shaun")]
    Shaun,

    [EnumMember(Value = "Theodore")]
    Theodore,

    [EnumMember(Value = "Timothy")]
    Timothy,

    [EnumMember(Value = "Wendy")]
    Wendy,

    [EnumMember(Value = "Dominus")]
    Dominus,

    [EnumMember(Value = "Hana")]
    Hana,

    [EnumMember(Value = "Clive")]
    Clive,

    [EnumMember(Value = "Carter")]
    Carter,

    [EnumMember(Value = "Blake")]
    Blake,

    [EnumMember(Value = "Luna")]
    Luna,

    [EnumMember(Value = "Yichen")]
    Yichen,

    [EnumMember(Value = "Xiaoyin")]
    Xiaoyin,

    [EnumMember(Value = "Xinyi")]
    Xinyi,

    [EnumMember(Value = "Jing")]
    Jing,

    [EnumMember(Value = "Erik")]
    Erik,

    [EnumMember(Value = "Katrien")]
    Katrien,

    [EnumMember(Value = "Lennart")]
    Lennart,

    [EnumMember(Value = "Lore")]
    Lore,

    [EnumMember(Value = "Alain")]
    Alain,

    [EnumMember(Value = "Hélène")]
    Helene,

    [EnumMember(Value = "Mathieu")]
    Mathieu,

    [EnumMember(Value = "Étienne")]
    Etienne,

    [EnumMember(Value = "Johanna")]
    Johanna,

    [EnumMember(Value = "Josef")]
    Josef,

    [EnumMember(Value = "Gianni")]
    Gianni,

    [EnumMember(Value = "Orietta")]
    Orietta,

    [EnumMember(Value = "Asuka")]
    Asuka,

    [EnumMember(Value = "Satoshi")]
    Satoshi,

    [EnumMember(Value = "Hyunwoo")]
    Hyunwoo,

    [EnumMember(Value = "Minji")]
    Minji,

    [EnumMember(Value = "Seojun")]
    Seojun,

    [EnumMember(Value = "Yoona")]
    Yoona,

    [EnumMember(Value = "Szymon")]
    Szymon,

    [EnumMember(Value = "Wojciech")]
    Wojciech,

    [EnumMember(Value = "Heitor")]
    Heitor,

    [EnumMember(Value = "Maitê")]
    Maite,

    [EnumMember(Value = "Diego")]
    Diego,

    [EnumMember(Value = "Lupita")]
    Lupita,

    [EnumMember(Value = "Miguel")]
    Miguel,

    [EnumMember(Value = "Rafael")]
    Rafael,

    [EnumMember(Value = "Svetlana")]
    Svetlana,

    [EnumMember(Value = "Elena")]
    Elena,

    [EnumMember(Value = "Dmitry")]
    Dmitry,

    [EnumMember(Value = "Nikolai")]
    Nikolai,

    [EnumMember(Value = "Riya")]
    Riya,

    [EnumMember(Value = "Manoj")]
    Manoj,

    [EnumMember(Value = "Yael")]
    Yael,

    [EnumMember(Value = "Oren")]
    Oren,

    [EnumMember(Value = "Nour")]
    Nour,

    [EnumMember(Value = "Omar")]
    Omar,
}

internal class FallbackInworldVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackInworldVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackInworldVoiceVoiceId
    > _stringToEnum = new()
    {
        { "Alex", FallbackInworldVoiceVoiceId.Alex },
        { "Ashley", FallbackInworldVoiceVoiceId.Ashley },
        { "Craig", FallbackInworldVoiceVoiceId.Craig },
        { "Deborah", FallbackInworldVoiceVoiceId.Deborah },
        { "Dennis", FallbackInworldVoiceVoiceId.Dennis },
        { "Edward", FallbackInworldVoiceVoiceId.Edward },
        { "Elizabeth", FallbackInworldVoiceVoiceId.Elizabeth },
        { "Hades", FallbackInworldVoiceVoiceId.Hades },
        { "Julia", FallbackInworldVoiceVoiceId.Julia },
        { "Pixie", FallbackInworldVoiceVoiceId.Pixie },
        { "Mark", FallbackInworldVoiceVoiceId.Mark },
        { "Olivia", FallbackInworldVoiceVoiceId.Olivia },
        { "Priya", FallbackInworldVoiceVoiceId.Priya },
        { "Ronald", FallbackInworldVoiceVoiceId.Ronald },
        { "Sarah", FallbackInworldVoiceVoiceId.Sarah },
        { "Shaun", FallbackInworldVoiceVoiceId.Shaun },
        { "Theodore", FallbackInworldVoiceVoiceId.Theodore },
        { "Timothy", FallbackInworldVoiceVoiceId.Timothy },
        { "Wendy", FallbackInworldVoiceVoiceId.Wendy },
        { "Dominus", FallbackInworldVoiceVoiceId.Dominus },
        { "Hana", FallbackInworldVoiceVoiceId.Hana },
        { "Clive", FallbackInworldVoiceVoiceId.Clive },
        { "Carter", FallbackInworldVoiceVoiceId.Carter },
        { "Blake", FallbackInworldVoiceVoiceId.Blake },
        { "Luna", FallbackInworldVoiceVoiceId.Luna },
        { "Yichen", FallbackInworldVoiceVoiceId.Yichen },
        { "Xiaoyin", FallbackInworldVoiceVoiceId.Xiaoyin },
        { "Xinyi", FallbackInworldVoiceVoiceId.Xinyi },
        { "Jing", FallbackInworldVoiceVoiceId.Jing },
        { "Erik", FallbackInworldVoiceVoiceId.Erik },
        { "Katrien", FallbackInworldVoiceVoiceId.Katrien },
        { "Lennart", FallbackInworldVoiceVoiceId.Lennart },
        { "Lore", FallbackInworldVoiceVoiceId.Lore },
        { "Alain", FallbackInworldVoiceVoiceId.Alain },
        { "Hélène", FallbackInworldVoiceVoiceId.Helene },
        { "Mathieu", FallbackInworldVoiceVoiceId.Mathieu },
        { "Étienne", FallbackInworldVoiceVoiceId.Etienne },
        { "Johanna", FallbackInworldVoiceVoiceId.Johanna },
        { "Josef", FallbackInworldVoiceVoiceId.Josef },
        { "Gianni", FallbackInworldVoiceVoiceId.Gianni },
        { "Orietta", FallbackInworldVoiceVoiceId.Orietta },
        { "Asuka", FallbackInworldVoiceVoiceId.Asuka },
        { "Satoshi", FallbackInworldVoiceVoiceId.Satoshi },
        { "Hyunwoo", FallbackInworldVoiceVoiceId.Hyunwoo },
        { "Minji", FallbackInworldVoiceVoiceId.Minji },
        { "Seojun", FallbackInworldVoiceVoiceId.Seojun },
        { "Yoona", FallbackInworldVoiceVoiceId.Yoona },
        { "Szymon", FallbackInworldVoiceVoiceId.Szymon },
        { "Wojciech", FallbackInworldVoiceVoiceId.Wojciech },
        { "Heitor", FallbackInworldVoiceVoiceId.Heitor },
        { "Maitê", FallbackInworldVoiceVoiceId.Maite },
        { "Diego", FallbackInworldVoiceVoiceId.Diego },
        { "Lupita", FallbackInworldVoiceVoiceId.Lupita },
        { "Miguel", FallbackInworldVoiceVoiceId.Miguel },
        { "Rafael", FallbackInworldVoiceVoiceId.Rafael },
        { "Svetlana", FallbackInworldVoiceVoiceId.Svetlana },
        { "Elena", FallbackInworldVoiceVoiceId.Elena },
        { "Dmitry", FallbackInworldVoiceVoiceId.Dmitry },
        { "Nikolai", FallbackInworldVoiceVoiceId.Nikolai },
        { "Riya", FallbackInworldVoiceVoiceId.Riya },
        { "Manoj", FallbackInworldVoiceVoiceId.Manoj },
        { "Yael", FallbackInworldVoiceVoiceId.Yael },
        { "Oren", FallbackInworldVoiceVoiceId.Oren },
        { "Nour", FallbackInworldVoiceVoiceId.Nour },
        { "Omar", FallbackInworldVoiceVoiceId.Omar },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackInworldVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { FallbackInworldVoiceVoiceId.Alex, "Alex" },
        { FallbackInworldVoiceVoiceId.Ashley, "Ashley" },
        { FallbackInworldVoiceVoiceId.Craig, "Craig" },
        { FallbackInworldVoiceVoiceId.Deborah, "Deborah" },
        { FallbackInworldVoiceVoiceId.Dennis, "Dennis" },
        { FallbackInworldVoiceVoiceId.Edward, "Edward" },
        { FallbackInworldVoiceVoiceId.Elizabeth, "Elizabeth" },
        { FallbackInworldVoiceVoiceId.Hades, "Hades" },
        { FallbackInworldVoiceVoiceId.Julia, "Julia" },
        { FallbackInworldVoiceVoiceId.Pixie, "Pixie" },
        { FallbackInworldVoiceVoiceId.Mark, "Mark" },
        { FallbackInworldVoiceVoiceId.Olivia, "Olivia" },
        { FallbackInworldVoiceVoiceId.Priya, "Priya" },
        { FallbackInworldVoiceVoiceId.Ronald, "Ronald" },
        { FallbackInworldVoiceVoiceId.Sarah, "Sarah" },
        { FallbackInworldVoiceVoiceId.Shaun, "Shaun" },
        { FallbackInworldVoiceVoiceId.Theodore, "Theodore" },
        { FallbackInworldVoiceVoiceId.Timothy, "Timothy" },
        { FallbackInworldVoiceVoiceId.Wendy, "Wendy" },
        { FallbackInworldVoiceVoiceId.Dominus, "Dominus" },
        { FallbackInworldVoiceVoiceId.Hana, "Hana" },
        { FallbackInworldVoiceVoiceId.Clive, "Clive" },
        { FallbackInworldVoiceVoiceId.Carter, "Carter" },
        { FallbackInworldVoiceVoiceId.Blake, "Blake" },
        { FallbackInworldVoiceVoiceId.Luna, "Luna" },
        { FallbackInworldVoiceVoiceId.Yichen, "Yichen" },
        { FallbackInworldVoiceVoiceId.Xiaoyin, "Xiaoyin" },
        { FallbackInworldVoiceVoiceId.Xinyi, "Xinyi" },
        { FallbackInworldVoiceVoiceId.Jing, "Jing" },
        { FallbackInworldVoiceVoiceId.Erik, "Erik" },
        { FallbackInworldVoiceVoiceId.Katrien, "Katrien" },
        { FallbackInworldVoiceVoiceId.Lennart, "Lennart" },
        { FallbackInworldVoiceVoiceId.Lore, "Lore" },
        { FallbackInworldVoiceVoiceId.Alain, "Alain" },
        { FallbackInworldVoiceVoiceId.Helene, "Hélène" },
        { FallbackInworldVoiceVoiceId.Mathieu, "Mathieu" },
        { FallbackInworldVoiceVoiceId.Etienne, "Étienne" },
        { FallbackInworldVoiceVoiceId.Johanna, "Johanna" },
        { FallbackInworldVoiceVoiceId.Josef, "Josef" },
        { FallbackInworldVoiceVoiceId.Gianni, "Gianni" },
        { FallbackInworldVoiceVoiceId.Orietta, "Orietta" },
        { FallbackInworldVoiceVoiceId.Asuka, "Asuka" },
        { FallbackInworldVoiceVoiceId.Satoshi, "Satoshi" },
        { FallbackInworldVoiceVoiceId.Hyunwoo, "Hyunwoo" },
        { FallbackInworldVoiceVoiceId.Minji, "Minji" },
        { FallbackInworldVoiceVoiceId.Seojun, "Seojun" },
        { FallbackInworldVoiceVoiceId.Yoona, "Yoona" },
        { FallbackInworldVoiceVoiceId.Szymon, "Szymon" },
        { FallbackInworldVoiceVoiceId.Wojciech, "Wojciech" },
        { FallbackInworldVoiceVoiceId.Heitor, "Heitor" },
        { FallbackInworldVoiceVoiceId.Maite, "Maitê" },
        { FallbackInworldVoiceVoiceId.Diego, "Diego" },
        { FallbackInworldVoiceVoiceId.Lupita, "Lupita" },
        { FallbackInworldVoiceVoiceId.Miguel, "Miguel" },
        { FallbackInworldVoiceVoiceId.Rafael, "Rafael" },
        { FallbackInworldVoiceVoiceId.Svetlana, "Svetlana" },
        { FallbackInworldVoiceVoiceId.Elena, "Elena" },
        { FallbackInworldVoiceVoiceId.Dmitry, "Dmitry" },
        { FallbackInworldVoiceVoiceId.Nikolai, "Nikolai" },
        { FallbackInworldVoiceVoiceId.Riya, "Riya" },
        { FallbackInworldVoiceVoiceId.Manoj, "Manoj" },
        { FallbackInworldVoiceVoiceId.Yael, "Yael" },
        { FallbackInworldVoiceVoiceId.Oren, "Oren" },
        { FallbackInworldVoiceVoiceId.Nour, "Nour" },
        { FallbackInworldVoiceVoiceId.Omar, "Omar" },
    };

    public override FallbackInworldVoiceVoiceId Read(
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
        FallbackInworldVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackInworldVoiceVoiceId ReadAsPropertyName(
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
        FallbackInworldVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
