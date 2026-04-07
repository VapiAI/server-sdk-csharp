using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackVapiVoiceVoiceIdSerializer))]
public enum FallbackVapiVoiceVoiceId
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

internal class FallbackVapiVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackVapiVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackVapiVoiceVoiceId
    > _stringToEnum = new()
    {
        { "Clara", FallbackVapiVoiceVoiceId.Clara },
        { "Godfrey", FallbackVapiVoiceVoiceId.Godfrey },
        { "Layla", FallbackVapiVoiceVoiceId.Layla },
        { "Sid", FallbackVapiVoiceVoiceId.Sid },
        { "Gustavo", FallbackVapiVoiceVoiceId.Gustavo },
        { "Elliot", FallbackVapiVoiceVoiceId.Elliot },
        { "Kylie", FallbackVapiVoiceVoiceId.Kylie },
        { "Rohan", FallbackVapiVoiceVoiceId.Rohan },
        { "Lily", FallbackVapiVoiceVoiceId.Lily },
        { "Savannah", FallbackVapiVoiceVoiceId.Savannah },
        { "Hana", FallbackVapiVoiceVoiceId.Hana },
        { "Neha", FallbackVapiVoiceVoiceId.Neha },
        { "Cole", FallbackVapiVoiceVoiceId.Cole },
        { "Harry", FallbackVapiVoiceVoiceId.Harry },
        { "Paige", FallbackVapiVoiceVoiceId.Paige },
        { "Spencer", FallbackVapiVoiceVoiceId.Spencer },
        { "Nico", FallbackVapiVoiceVoiceId.Nico },
        { "Kai", FallbackVapiVoiceVoiceId.Kai },
        { "Emma", FallbackVapiVoiceVoiceId.Emma },
        { "Sagar", FallbackVapiVoiceVoiceId.Sagar },
        { "Neil", FallbackVapiVoiceVoiceId.Neil },
        { "Naina", FallbackVapiVoiceVoiceId.Naina },
        { "Leah", FallbackVapiVoiceVoiceId.Leah },
        { "Tara", FallbackVapiVoiceVoiceId.Tara },
        { "Jess", FallbackVapiVoiceVoiceId.Jess },
        { "Leo", FallbackVapiVoiceVoiceId.Leo },
        { "Dan", FallbackVapiVoiceVoiceId.Dan },
        { "Mia", FallbackVapiVoiceVoiceId.Mia },
        { "Zac", FallbackVapiVoiceVoiceId.Zac },
        { "Zoe", FallbackVapiVoiceVoiceId.Zoe },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackVapiVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { FallbackVapiVoiceVoiceId.Clara, "Clara" },
        { FallbackVapiVoiceVoiceId.Godfrey, "Godfrey" },
        { FallbackVapiVoiceVoiceId.Layla, "Layla" },
        { FallbackVapiVoiceVoiceId.Sid, "Sid" },
        { FallbackVapiVoiceVoiceId.Gustavo, "Gustavo" },
        { FallbackVapiVoiceVoiceId.Elliot, "Elliot" },
        { FallbackVapiVoiceVoiceId.Kylie, "Kylie" },
        { FallbackVapiVoiceVoiceId.Rohan, "Rohan" },
        { FallbackVapiVoiceVoiceId.Lily, "Lily" },
        { FallbackVapiVoiceVoiceId.Savannah, "Savannah" },
        { FallbackVapiVoiceVoiceId.Hana, "Hana" },
        { FallbackVapiVoiceVoiceId.Neha, "Neha" },
        { FallbackVapiVoiceVoiceId.Cole, "Cole" },
        { FallbackVapiVoiceVoiceId.Harry, "Harry" },
        { FallbackVapiVoiceVoiceId.Paige, "Paige" },
        { FallbackVapiVoiceVoiceId.Spencer, "Spencer" },
        { FallbackVapiVoiceVoiceId.Nico, "Nico" },
        { FallbackVapiVoiceVoiceId.Kai, "Kai" },
        { FallbackVapiVoiceVoiceId.Emma, "Emma" },
        { FallbackVapiVoiceVoiceId.Sagar, "Sagar" },
        { FallbackVapiVoiceVoiceId.Neil, "Neil" },
        { FallbackVapiVoiceVoiceId.Naina, "Naina" },
        { FallbackVapiVoiceVoiceId.Leah, "Leah" },
        { FallbackVapiVoiceVoiceId.Tara, "Tara" },
        { FallbackVapiVoiceVoiceId.Jess, "Jess" },
        { FallbackVapiVoiceVoiceId.Leo, "Leo" },
        { FallbackVapiVoiceVoiceId.Dan, "Dan" },
        { FallbackVapiVoiceVoiceId.Mia, "Mia" },
        { FallbackVapiVoiceVoiceId.Zac, "Zac" },
        { FallbackVapiVoiceVoiceId.Zoe, "Zoe" },
    };

    public override FallbackVapiVoiceVoiceId Read(
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
        FallbackVapiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackVapiVoiceVoiceId ReadAsPropertyName(
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
        FallbackVapiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
