using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InworldVoiceVoiceIdSerializer))]
public enum InworldVoiceVoiceId
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

internal class InworldVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InworldVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InworldVoiceVoiceId
    > _stringToEnum = new()
    {
        { "Alex", InworldVoiceVoiceId.Alex },
        { "Ashley", InworldVoiceVoiceId.Ashley },
        { "Craig", InworldVoiceVoiceId.Craig },
        { "Deborah", InworldVoiceVoiceId.Deborah },
        { "Dennis", InworldVoiceVoiceId.Dennis },
        { "Edward", InworldVoiceVoiceId.Edward },
        { "Elizabeth", InworldVoiceVoiceId.Elizabeth },
        { "Hades", InworldVoiceVoiceId.Hades },
        { "Julia", InworldVoiceVoiceId.Julia },
        { "Pixie", InworldVoiceVoiceId.Pixie },
        { "Mark", InworldVoiceVoiceId.Mark },
        { "Olivia", InworldVoiceVoiceId.Olivia },
        { "Priya", InworldVoiceVoiceId.Priya },
        { "Ronald", InworldVoiceVoiceId.Ronald },
        { "Sarah", InworldVoiceVoiceId.Sarah },
        { "Shaun", InworldVoiceVoiceId.Shaun },
        { "Theodore", InworldVoiceVoiceId.Theodore },
        { "Timothy", InworldVoiceVoiceId.Timothy },
        { "Wendy", InworldVoiceVoiceId.Wendy },
        { "Dominus", InworldVoiceVoiceId.Dominus },
        { "Hana", InworldVoiceVoiceId.Hana },
        { "Clive", InworldVoiceVoiceId.Clive },
        { "Carter", InworldVoiceVoiceId.Carter },
        { "Blake", InworldVoiceVoiceId.Blake },
        { "Luna", InworldVoiceVoiceId.Luna },
        { "Yichen", InworldVoiceVoiceId.Yichen },
        { "Xiaoyin", InworldVoiceVoiceId.Xiaoyin },
        { "Xinyi", InworldVoiceVoiceId.Xinyi },
        { "Jing", InworldVoiceVoiceId.Jing },
        { "Erik", InworldVoiceVoiceId.Erik },
        { "Katrien", InworldVoiceVoiceId.Katrien },
        { "Lennart", InworldVoiceVoiceId.Lennart },
        { "Lore", InworldVoiceVoiceId.Lore },
        { "Alain", InworldVoiceVoiceId.Alain },
        { "Hélène", InworldVoiceVoiceId.Helene },
        { "Mathieu", InworldVoiceVoiceId.Mathieu },
        { "Étienne", InworldVoiceVoiceId.Etienne },
        { "Johanna", InworldVoiceVoiceId.Johanna },
        { "Josef", InworldVoiceVoiceId.Josef },
        { "Gianni", InworldVoiceVoiceId.Gianni },
        { "Orietta", InworldVoiceVoiceId.Orietta },
        { "Asuka", InworldVoiceVoiceId.Asuka },
        { "Satoshi", InworldVoiceVoiceId.Satoshi },
        { "Hyunwoo", InworldVoiceVoiceId.Hyunwoo },
        { "Minji", InworldVoiceVoiceId.Minji },
        { "Seojun", InworldVoiceVoiceId.Seojun },
        { "Yoona", InworldVoiceVoiceId.Yoona },
        { "Szymon", InworldVoiceVoiceId.Szymon },
        { "Wojciech", InworldVoiceVoiceId.Wojciech },
        { "Heitor", InworldVoiceVoiceId.Heitor },
        { "Maitê", InworldVoiceVoiceId.Maite },
        { "Diego", InworldVoiceVoiceId.Diego },
        { "Lupita", InworldVoiceVoiceId.Lupita },
        { "Miguel", InworldVoiceVoiceId.Miguel },
        { "Rafael", InworldVoiceVoiceId.Rafael },
        { "Svetlana", InworldVoiceVoiceId.Svetlana },
        { "Elena", InworldVoiceVoiceId.Elena },
        { "Dmitry", InworldVoiceVoiceId.Dmitry },
        { "Nikolai", InworldVoiceVoiceId.Nikolai },
        { "Riya", InworldVoiceVoiceId.Riya },
        { "Manoj", InworldVoiceVoiceId.Manoj },
        { "Yael", InworldVoiceVoiceId.Yael },
        { "Oren", InworldVoiceVoiceId.Oren },
        { "Nour", InworldVoiceVoiceId.Nour },
        { "Omar", InworldVoiceVoiceId.Omar },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InworldVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { InworldVoiceVoiceId.Alex, "Alex" },
        { InworldVoiceVoiceId.Ashley, "Ashley" },
        { InworldVoiceVoiceId.Craig, "Craig" },
        { InworldVoiceVoiceId.Deborah, "Deborah" },
        { InworldVoiceVoiceId.Dennis, "Dennis" },
        { InworldVoiceVoiceId.Edward, "Edward" },
        { InworldVoiceVoiceId.Elizabeth, "Elizabeth" },
        { InworldVoiceVoiceId.Hades, "Hades" },
        { InworldVoiceVoiceId.Julia, "Julia" },
        { InworldVoiceVoiceId.Pixie, "Pixie" },
        { InworldVoiceVoiceId.Mark, "Mark" },
        { InworldVoiceVoiceId.Olivia, "Olivia" },
        { InworldVoiceVoiceId.Priya, "Priya" },
        { InworldVoiceVoiceId.Ronald, "Ronald" },
        { InworldVoiceVoiceId.Sarah, "Sarah" },
        { InworldVoiceVoiceId.Shaun, "Shaun" },
        { InworldVoiceVoiceId.Theodore, "Theodore" },
        { InworldVoiceVoiceId.Timothy, "Timothy" },
        { InworldVoiceVoiceId.Wendy, "Wendy" },
        { InworldVoiceVoiceId.Dominus, "Dominus" },
        { InworldVoiceVoiceId.Hana, "Hana" },
        { InworldVoiceVoiceId.Clive, "Clive" },
        { InworldVoiceVoiceId.Carter, "Carter" },
        { InworldVoiceVoiceId.Blake, "Blake" },
        { InworldVoiceVoiceId.Luna, "Luna" },
        { InworldVoiceVoiceId.Yichen, "Yichen" },
        { InworldVoiceVoiceId.Xiaoyin, "Xiaoyin" },
        { InworldVoiceVoiceId.Xinyi, "Xinyi" },
        { InworldVoiceVoiceId.Jing, "Jing" },
        { InworldVoiceVoiceId.Erik, "Erik" },
        { InworldVoiceVoiceId.Katrien, "Katrien" },
        { InworldVoiceVoiceId.Lennart, "Lennart" },
        { InworldVoiceVoiceId.Lore, "Lore" },
        { InworldVoiceVoiceId.Alain, "Alain" },
        { InworldVoiceVoiceId.Helene, "Hélène" },
        { InworldVoiceVoiceId.Mathieu, "Mathieu" },
        { InworldVoiceVoiceId.Etienne, "Étienne" },
        { InworldVoiceVoiceId.Johanna, "Johanna" },
        { InworldVoiceVoiceId.Josef, "Josef" },
        { InworldVoiceVoiceId.Gianni, "Gianni" },
        { InworldVoiceVoiceId.Orietta, "Orietta" },
        { InworldVoiceVoiceId.Asuka, "Asuka" },
        { InworldVoiceVoiceId.Satoshi, "Satoshi" },
        { InworldVoiceVoiceId.Hyunwoo, "Hyunwoo" },
        { InworldVoiceVoiceId.Minji, "Minji" },
        { InworldVoiceVoiceId.Seojun, "Seojun" },
        { InworldVoiceVoiceId.Yoona, "Yoona" },
        { InworldVoiceVoiceId.Szymon, "Szymon" },
        { InworldVoiceVoiceId.Wojciech, "Wojciech" },
        { InworldVoiceVoiceId.Heitor, "Heitor" },
        { InworldVoiceVoiceId.Maite, "Maitê" },
        { InworldVoiceVoiceId.Diego, "Diego" },
        { InworldVoiceVoiceId.Lupita, "Lupita" },
        { InworldVoiceVoiceId.Miguel, "Miguel" },
        { InworldVoiceVoiceId.Rafael, "Rafael" },
        { InworldVoiceVoiceId.Svetlana, "Svetlana" },
        { InworldVoiceVoiceId.Elena, "Elena" },
        { InworldVoiceVoiceId.Dmitry, "Dmitry" },
        { InworldVoiceVoiceId.Nikolai, "Nikolai" },
        { InworldVoiceVoiceId.Riya, "Riya" },
        { InworldVoiceVoiceId.Manoj, "Manoj" },
        { InworldVoiceVoiceId.Yael, "Yael" },
        { InworldVoiceVoiceId.Oren, "Oren" },
        { InworldVoiceVoiceId.Nour, "Nour" },
        { InworldVoiceVoiceId.Omar, "Omar" },
    };

    public override InworldVoiceVoiceId Read(
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
        InworldVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InworldVoiceVoiceId ReadAsPropertyName(
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
        InworldVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
