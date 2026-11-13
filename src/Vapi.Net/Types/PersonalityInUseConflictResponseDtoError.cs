using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PersonalityInUseConflictResponseDtoErrorSerializer))]
public enum PersonalityInUseConflictResponseDtoError
{
    [EnumMember(Value = "personality_in_use")]
    PersonalityInUse,
}

internal class PersonalityInUseConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PersonalityInUseConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PersonalityInUseConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "personality_in_use", PersonalityInUseConflictResponseDtoError.PersonalityInUse },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PersonalityInUseConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { PersonalityInUseConflictResponseDtoError.PersonalityInUse, "personality_in_use" },
    };

    public override PersonalityInUseConflictResponseDtoError Read(
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
        PersonalityInUseConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PersonalityInUseConflictResponseDtoError ReadAsPropertyName(
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
        PersonalityInUseConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
