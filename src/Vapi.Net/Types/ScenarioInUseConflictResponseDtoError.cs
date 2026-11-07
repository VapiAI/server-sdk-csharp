using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ScenarioInUseConflictResponseDtoErrorSerializer))]
public enum ScenarioInUseConflictResponseDtoError
{
    [EnumMember(Value = "scenario_in_use")]
    ScenarioInUse,
}

internal class ScenarioInUseConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ScenarioInUseConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ScenarioInUseConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "scenario_in_use", ScenarioInUseConflictResponseDtoError.ScenarioInUse },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ScenarioInUseConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { ScenarioInUseConflictResponseDtoError.ScenarioInUse, "scenario_in_use" },
    };

    public override ScenarioInUseConflictResponseDtoError Read(
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
        ScenarioInUseConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ScenarioInUseConflictResponseDtoError ReadAsPropertyName(
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
        ScenarioInUseConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
