using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MicrosoftVoiceRoleSerializer))]
public enum MicrosoftVoiceRole
{
    [EnumMember(Value = "Girl")]
    Girl,

    [EnumMember(Value = "Boy")]
    Boy,

    [EnumMember(Value = "YoungAdultFemale")]
    YoungAdultFemale,

    [EnumMember(Value = "YoungAdultMale")]
    YoungAdultMale,

    [EnumMember(Value = "OlderAdultFemale")]
    OlderAdultFemale,

    [EnumMember(Value = "OlderAdultMale")]
    OlderAdultMale,

    [EnumMember(Value = "SeniorFemale")]
    SeniorFemale,

    [EnumMember(Value = "SeniorMale")]
    SeniorMale,
}

internal class MicrosoftVoiceRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MicrosoftVoiceRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MicrosoftVoiceRole
    > _stringToEnum = new()
    {
        { "Girl", MicrosoftVoiceRole.Girl },
        { "Boy", MicrosoftVoiceRole.Boy },
        { "YoungAdultFemale", MicrosoftVoiceRole.YoungAdultFemale },
        { "YoungAdultMale", MicrosoftVoiceRole.YoungAdultMale },
        { "OlderAdultFemale", MicrosoftVoiceRole.OlderAdultFemale },
        { "OlderAdultMale", MicrosoftVoiceRole.OlderAdultMale },
        { "SeniorFemale", MicrosoftVoiceRole.SeniorFemale },
        { "SeniorMale", MicrosoftVoiceRole.SeniorMale },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MicrosoftVoiceRole,
        string
    > _enumToString = new()
    {
        { MicrosoftVoiceRole.Girl, "Girl" },
        { MicrosoftVoiceRole.Boy, "Boy" },
        { MicrosoftVoiceRole.YoungAdultFemale, "YoungAdultFemale" },
        { MicrosoftVoiceRole.YoungAdultMale, "YoungAdultMale" },
        { MicrosoftVoiceRole.OlderAdultFemale, "OlderAdultFemale" },
        { MicrosoftVoiceRole.OlderAdultMale, "OlderAdultMale" },
        { MicrosoftVoiceRole.SeniorFemale, "SeniorFemale" },
        { MicrosoftVoiceRole.SeniorMale, "SeniorMale" },
    };

    public override MicrosoftVoiceRole Read(
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
        MicrosoftVoiceRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MicrosoftVoiceRole ReadAsPropertyName(
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
        MicrosoftVoiceRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
