using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiVoiceIdEnumSerializer))]
public enum OpenAiVoiceIdEnum
{
    [EnumMember(Value = "alloy")]
    Alloy,

    [EnumMember(Value = "echo")]
    Echo,

    [EnumMember(Value = "fable")]
    Fable,

    [EnumMember(Value = "onyx")]
    Onyx,

    [EnumMember(Value = "nova")]
    Nova,

    [EnumMember(Value = "shimmer")]
    Shimmer,

    [EnumMember(Value = "marin")]
    Marin,

    [EnumMember(Value = "cedar")]
    Cedar,
}

internal class OpenAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "alloy", OpenAiVoiceIdEnum.Alloy },
        { "echo", OpenAiVoiceIdEnum.Echo },
        { "fable", OpenAiVoiceIdEnum.Fable },
        { "onyx", OpenAiVoiceIdEnum.Onyx },
        { "nova", OpenAiVoiceIdEnum.Nova },
        { "shimmer", OpenAiVoiceIdEnum.Shimmer },
        { "marin", OpenAiVoiceIdEnum.Marin },
        { "cedar", OpenAiVoiceIdEnum.Cedar },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { OpenAiVoiceIdEnum.Alloy, "alloy" },
        { OpenAiVoiceIdEnum.Echo, "echo" },
        { OpenAiVoiceIdEnum.Fable, "fable" },
        { OpenAiVoiceIdEnum.Onyx, "onyx" },
        { OpenAiVoiceIdEnum.Nova, "nova" },
        { OpenAiVoiceIdEnum.Shimmer, "shimmer" },
        { OpenAiVoiceIdEnum.Marin, "marin" },
        { OpenAiVoiceIdEnum.Cedar, "cedar" },
    };

    public override OpenAiVoiceIdEnum Read(
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
        OpenAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiVoiceIdEnum ReadAsPropertyName(
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
        OpenAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
