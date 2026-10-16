using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMicrosoftVoiceRoleSerializer))]
public enum FallbackMicrosoftVoiceRole
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

internal class FallbackMicrosoftVoiceRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMicrosoftVoiceRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMicrosoftVoiceRole
    > _stringToEnum = new()
    {
        { "Girl", FallbackMicrosoftVoiceRole.Girl },
        { "Boy", FallbackMicrosoftVoiceRole.Boy },
        { "YoungAdultFemale", FallbackMicrosoftVoiceRole.YoungAdultFemale },
        { "YoungAdultMale", FallbackMicrosoftVoiceRole.YoungAdultMale },
        { "OlderAdultFemale", FallbackMicrosoftVoiceRole.OlderAdultFemale },
        { "OlderAdultMale", FallbackMicrosoftVoiceRole.OlderAdultMale },
        { "SeniorFemale", FallbackMicrosoftVoiceRole.SeniorFemale },
        { "SeniorMale", FallbackMicrosoftVoiceRole.SeniorMale },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMicrosoftVoiceRole,
        string
    > _enumToString = new()
    {
        { FallbackMicrosoftVoiceRole.Girl, "Girl" },
        { FallbackMicrosoftVoiceRole.Boy, "Boy" },
        { FallbackMicrosoftVoiceRole.YoungAdultFemale, "YoungAdultFemale" },
        { FallbackMicrosoftVoiceRole.YoungAdultMale, "YoungAdultMale" },
        { FallbackMicrosoftVoiceRole.OlderAdultFemale, "OlderAdultFemale" },
        { FallbackMicrosoftVoiceRole.OlderAdultMale, "OlderAdultMale" },
        { FallbackMicrosoftVoiceRole.SeniorFemale, "SeniorFemale" },
        { FallbackMicrosoftVoiceRole.SeniorMale, "SeniorMale" },
    };

    public override FallbackMicrosoftVoiceRole Read(
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
        FallbackMicrosoftVoiceRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMicrosoftVoiceRole ReadAsPropertyName(
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
        FallbackMicrosoftVoiceRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
