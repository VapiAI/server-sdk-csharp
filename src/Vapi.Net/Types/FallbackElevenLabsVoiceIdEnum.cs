using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackElevenLabsVoiceIdEnumSerializer))]
public enum FallbackElevenLabsVoiceIdEnum
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

internal class FallbackElevenLabsVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackElevenLabsVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackElevenLabsVoiceIdEnum
    > _stringToEnum = new()
    {
        { "burt", FallbackElevenLabsVoiceIdEnum.Burt },
        { "marissa", FallbackElevenLabsVoiceIdEnum.Marissa },
        { "andrea", FallbackElevenLabsVoiceIdEnum.Andrea },
        { "sarah", FallbackElevenLabsVoiceIdEnum.Sarah },
        { "phillip", FallbackElevenLabsVoiceIdEnum.Phillip },
        { "steve", FallbackElevenLabsVoiceIdEnum.Steve },
        { "joseph", FallbackElevenLabsVoiceIdEnum.Joseph },
        { "myra", FallbackElevenLabsVoiceIdEnum.Myra },
        { "paula", FallbackElevenLabsVoiceIdEnum.Paula },
        { "ryan", FallbackElevenLabsVoiceIdEnum.Ryan },
        { "drew", FallbackElevenLabsVoiceIdEnum.Drew },
        { "paul", FallbackElevenLabsVoiceIdEnum.Paul },
        { "mrb", FallbackElevenLabsVoiceIdEnum.Mrb },
        { "matilda", FallbackElevenLabsVoiceIdEnum.Matilda },
        { "mark", FallbackElevenLabsVoiceIdEnum.Mark },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackElevenLabsVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { FallbackElevenLabsVoiceIdEnum.Burt, "burt" },
        { FallbackElevenLabsVoiceIdEnum.Marissa, "marissa" },
        { FallbackElevenLabsVoiceIdEnum.Andrea, "andrea" },
        { FallbackElevenLabsVoiceIdEnum.Sarah, "sarah" },
        { FallbackElevenLabsVoiceIdEnum.Phillip, "phillip" },
        { FallbackElevenLabsVoiceIdEnum.Steve, "steve" },
        { FallbackElevenLabsVoiceIdEnum.Joseph, "joseph" },
        { FallbackElevenLabsVoiceIdEnum.Myra, "myra" },
        { FallbackElevenLabsVoiceIdEnum.Paula, "paula" },
        { FallbackElevenLabsVoiceIdEnum.Ryan, "ryan" },
        { FallbackElevenLabsVoiceIdEnum.Drew, "drew" },
        { FallbackElevenLabsVoiceIdEnum.Paul, "paul" },
        { FallbackElevenLabsVoiceIdEnum.Mrb, "mrb" },
        { FallbackElevenLabsVoiceIdEnum.Matilda, "matilda" },
        { FallbackElevenLabsVoiceIdEnum.Mark, "mark" },
    };

    public override FallbackElevenLabsVoiceIdEnum Read(
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
        FallbackElevenLabsVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackElevenLabsVoiceIdEnum ReadAsPropertyName(
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
        FallbackElevenLabsVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
