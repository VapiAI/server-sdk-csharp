using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VoiceLibraryGenderSerializer))]
public enum VoiceLibraryGender
{
    [EnumMember(Value = "male")]
    Male,

    [EnumMember(Value = "female")]
    Female,
}

internal class VoiceLibraryGenderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VoiceLibraryGender>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VoiceLibraryGender
    > _stringToEnum = new()
    {
        { "male", VoiceLibraryGender.Male },
        { "female", VoiceLibraryGender.Female },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VoiceLibraryGender,
        string
    > _enumToString = new()
    {
        { VoiceLibraryGender.Male, "male" },
        { VoiceLibraryGender.Female, "female" },
    };

    public override VoiceLibraryGender Read(
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
        VoiceLibraryGender value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VoiceLibraryGender ReadAsPropertyName(
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
        VoiceLibraryGender value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
