using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiVoiceVoiceIdSerializer))]
public enum VapiVoiceVoiceId
{
    [EnumMember(Value = "Clara")]
    Clara,

    [EnumMember(Value = "Godfrey")]
    Godfrey,

    [EnumMember(Value = "Layla")]
    Layla,

    [EnumMember(Value = "Sid")]
    Sid,

    [EnumMember(Value = "Gustavo")]
    Gustavo,

    [EnumMember(Value = "Elliot")]
    Elliot,

    [EnumMember(Value = "Kylie")]
    Kylie,

    [EnumMember(Value = "Rohan")]
    Rohan,

    [EnumMember(Value = "Lily")]
    Lily,

    [EnumMember(Value = "Savannah")]
    Savannah,

    [EnumMember(Value = "Hana")]
    Hana,

    [EnumMember(Value = "Neha")]
    Neha,

    [EnumMember(Value = "Cole")]
    Cole,

    [EnumMember(Value = "Harry")]
    Harry,

    [EnumMember(Value = "Paige")]
    Paige,

    [EnumMember(Value = "Spencer")]
    Spencer,

    [EnumMember(Value = "Nico")]
    Nico,

    [EnumMember(Value = "Kai")]
    Kai,

    [EnumMember(Value = "Emma")]
    Emma,

    [EnumMember(Value = "Sagar")]
    Sagar,

    [EnumMember(Value = "Neil")]
    Neil,

    [EnumMember(Value = "Naina")]
    Naina,

    [EnumMember(Value = "Leah")]
    Leah,

    [EnumMember(Value = "Tara")]
    Tara,

    [EnumMember(Value = "Jess")]
    Jess,

    [EnumMember(Value = "Leo")]
    Leo,

    [EnumMember(Value = "Dan")]
    Dan,

    [EnumMember(Value = "Mia")]
    Mia,

    [EnumMember(Value = "Zac")]
    Zac,

    [EnumMember(Value = "Zoe")]
    Zoe,
}

internal class VapiVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiVoiceVoiceId
    > _stringToEnum = new()
    {
        { "Clara", VapiVoiceVoiceId.Clara },
        { "Godfrey", VapiVoiceVoiceId.Godfrey },
        { "Layla", VapiVoiceVoiceId.Layla },
        { "Sid", VapiVoiceVoiceId.Sid },
        { "Gustavo", VapiVoiceVoiceId.Gustavo },
        { "Elliot", VapiVoiceVoiceId.Elliot },
        { "Kylie", VapiVoiceVoiceId.Kylie },
        { "Rohan", VapiVoiceVoiceId.Rohan },
        { "Lily", VapiVoiceVoiceId.Lily },
        { "Savannah", VapiVoiceVoiceId.Savannah },
        { "Hana", VapiVoiceVoiceId.Hana },
        { "Neha", VapiVoiceVoiceId.Neha },
        { "Cole", VapiVoiceVoiceId.Cole },
        { "Harry", VapiVoiceVoiceId.Harry },
        { "Paige", VapiVoiceVoiceId.Paige },
        { "Spencer", VapiVoiceVoiceId.Spencer },
        { "Nico", VapiVoiceVoiceId.Nico },
        { "Kai", VapiVoiceVoiceId.Kai },
        { "Emma", VapiVoiceVoiceId.Emma },
        { "Sagar", VapiVoiceVoiceId.Sagar },
        { "Neil", VapiVoiceVoiceId.Neil },
        { "Naina", VapiVoiceVoiceId.Naina },
        { "Leah", VapiVoiceVoiceId.Leah },
        { "Tara", VapiVoiceVoiceId.Tara },
        { "Jess", VapiVoiceVoiceId.Jess },
        { "Leo", VapiVoiceVoiceId.Leo },
        { "Dan", VapiVoiceVoiceId.Dan },
        { "Mia", VapiVoiceVoiceId.Mia },
        { "Zac", VapiVoiceVoiceId.Zac },
        { "Zoe", VapiVoiceVoiceId.Zoe },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { VapiVoiceVoiceId.Clara, "Clara" },
        { VapiVoiceVoiceId.Godfrey, "Godfrey" },
        { VapiVoiceVoiceId.Layla, "Layla" },
        { VapiVoiceVoiceId.Sid, "Sid" },
        { VapiVoiceVoiceId.Gustavo, "Gustavo" },
        { VapiVoiceVoiceId.Elliot, "Elliot" },
        { VapiVoiceVoiceId.Kylie, "Kylie" },
        { VapiVoiceVoiceId.Rohan, "Rohan" },
        { VapiVoiceVoiceId.Lily, "Lily" },
        { VapiVoiceVoiceId.Savannah, "Savannah" },
        { VapiVoiceVoiceId.Hana, "Hana" },
        { VapiVoiceVoiceId.Neha, "Neha" },
        { VapiVoiceVoiceId.Cole, "Cole" },
        { VapiVoiceVoiceId.Harry, "Harry" },
        { VapiVoiceVoiceId.Paige, "Paige" },
        { VapiVoiceVoiceId.Spencer, "Spencer" },
        { VapiVoiceVoiceId.Nico, "Nico" },
        { VapiVoiceVoiceId.Kai, "Kai" },
        { VapiVoiceVoiceId.Emma, "Emma" },
        { VapiVoiceVoiceId.Sagar, "Sagar" },
        { VapiVoiceVoiceId.Neil, "Neil" },
        { VapiVoiceVoiceId.Naina, "Naina" },
        { VapiVoiceVoiceId.Leah, "Leah" },
        { VapiVoiceVoiceId.Tara, "Tara" },
        { VapiVoiceVoiceId.Jess, "Jess" },
        { VapiVoiceVoiceId.Leo, "Leo" },
        { VapiVoiceVoiceId.Dan, "Dan" },
        { VapiVoiceVoiceId.Mia, "Mia" },
        { VapiVoiceVoiceId.Zac, "Zac" },
        { VapiVoiceVoiceId.Zoe, "Zoe" },
    };

    public override VapiVoiceVoiceId Read(
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
        VapiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiVoiceVoiceId ReadAsPropertyName(
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
        VapiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
