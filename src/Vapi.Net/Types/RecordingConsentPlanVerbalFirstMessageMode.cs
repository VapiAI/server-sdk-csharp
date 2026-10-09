using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RecordingConsentPlanVerbalFirstMessageModeSerializer))]
public enum RecordingConsentPlanVerbalFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class RecordingConsentPlanVerbalFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RecordingConsentPlanVerbalFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RecordingConsentPlanVerbalFirstMessageMode
    > _stringToEnum = new()
    {
        {
            "assistant-speaks-first",
            RecordingConsentPlanVerbalFirstMessageMode.AssistantSpeaksFirst
        },
        {
            "assistant-waits-for-user",
            RecordingConsentPlanVerbalFirstMessageMode.AssistantWaitsForUser
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RecordingConsentPlanVerbalFirstMessageMode,
        string
    > _enumToString = new()
    {
        {
            RecordingConsentPlanVerbalFirstMessageMode.AssistantSpeaksFirst,
            "assistant-speaks-first"
        },
        {
            RecordingConsentPlanVerbalFirstMessageMode.AssistantWaitsForUser,
            "assistant-waits-for-user"
        },
    };

    public override RecordingConsentPlanVerbalFirstMessageMode Read(
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
        RecordingConsentPlanVerbalFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RecordingConsentPlanVerbalFirstMessageMode ReadAsPropertyName(
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
        RecordingConsentPlanVerbalFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
