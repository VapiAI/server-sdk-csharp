using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsVoiceIdEnumSerializer))]
public enum ElevenLabsVoiceIdEnum
{
    [EnumMember(Value = "burt")]
    Burt,

    [EnumMember(Value = "marissa")]
    Marissa,

    [EnumMember(Value = "andrea")]
    Andrea,

    [EnumMember(Value = "sarah")]
    Sarah,

    [EnumMember(Value = "phillip")]
    Phillip,

    [EnumMember(Value = "steve")]
    Steve,

    [EnumMember(Value = "joseph")]
    Joseph,

    [EnumMember(Value = "myra")]
    Myra,

    [EnumMember(Value = "paula")]
    Paula,

    [EnumMember(Value = "ryan")]
    Ryan,

    [EnumMember(Value = "drew")]
    Drew,

    [EnumMember(Value = "paul")]
    Paul,

    [EnumMember(Value = "mrb")]
    Mrb,

    [EnumMember(Value = "matilda")]
    Matilda,

    [EnumMember(Value = "mark")]
    Mark,
}

internal class ElevenLabsVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsVoiceIdEnum
    > _stringToEnum = new()
    {
        { "burt", ElevenLabsVoiceIdEnum.Burt },
        { "marissa", ElevenLabsVoiceIdEnum.Marissa },
        { "andrea", ElevenLabsVoiceIdEnum.Andrea },
        { "sarah", ElevenLabsVoiceIdEnum.Sarah },
        { "phillip", ElevenLabsVoiceIdEnum.Phillip },
        { "steve", ElevenLabsVoiceIdEnum.Steve },
        { "joseph", ElevenLabsVoiceIdEnum.Joseph },
        { "myra", ElevenLabsVoiceIdEnum.Myra },
        { "paula", ElevenLabsVoiceIdEnum.Paula },
        { "ryan", ElevenLabsVoiceIdEnum.Ryan },
        { "drew", ElevenLabsVoiceIdEnum.Drew },
        { "paul", ElevenLabsVoiceIdEnum.Paul },
        { "mrb", ElevenLabsVoiceIdEnum.Mrb },
        { "matilda", ElevenLabsVoiceIdEnum.Matilda },
        { "mark", ElevenLabsVoiceIdEnum.Mark },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { ElevenLabsVoiceIdEnum.Burt, "burt" },
        { ElevenLabsVoiceIdEnum.Marissa, "marissa" },
        { ElevenLabsVoiceIdEnum.Andrea, "andrea" },
        { ElevenLabsVoiceIdEnum.Sarah, "sarah" },
        { ElevenLabsVoiceIdEnum.Phillip, "phillip" },
        { ElevenLabsVoiceIdEnum.Steve, "steve" },
        { ElevenLabsVoiceIdEnum.Joseph, "joseph" },
        { ElevenLabsVoiceIdEnum.Myra, "myra" },
        { ElevenLabsVoiceIdEnum.Paula, "paula" },
        { ElevenLabsVoiceIdEnum.Ryan, "ryan" },
        { ElevenLabsVoiceIdEnum.Drew, "drew" },
        { ElevenLabsVoiceIdEnum.Paul, "paul" },
        { ElevenLabsVoiceIdEnum.Mrb, "mrb" },
        { ElevenLabsVoiceIdEnum.Matilda, "matilda" },
        { ElevenLabsVoiceIdEnum.Mark, "mark" },
    };

    public override ElevenLabsVoiceIdEnum Read(
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
        ElevenLabsVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsVoiceIdEnum ReadAsPropertyName(
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
        ElevenLabsVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
