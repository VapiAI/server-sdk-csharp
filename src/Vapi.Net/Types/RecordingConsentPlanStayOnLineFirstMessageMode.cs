using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RecordingConsentPlanStayOnLineFirstMessageModeSerializer))]
public enum RecordingConsentPlanStayOnLineFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class RecordingConsentPlanStayOnLineFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RecordingConsentPlanStayOnLineFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RecordingConsentPlanStayOnLineFirstMessageMode
    > _stringToEnum = new()
    {
        {
            "assistant-speaks-first",
            RecordingConsentPlanStayOnLineFirstMessageMode.AssistantSpeaksFirst
        },
        {
            "assistant-waits-for-user",
            RecordingConsentPlanStayOnLineFirstMessageMode.AssistantWaitsForUser
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RecordingConsentPlanStayOnLineFirstMessageMode,
        string
    > _enumToString = new()
    {
        {
            RecordingConsentPlanStayOnLineFirstMessageMode.AssistantSpeaksFirst,
            "assistant-speaks-first"
        },
        {
            RecordingConsentPlanStayOnLineFirstMessageMode.AssistantWaitsForUser,
            "assistant-waits-for-user"
        },
    };

    public override RecordingConsentPlanStayOnLineFirstMessageMode Read(
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
        RecordingConsentPlanStayOnLineFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RecordingConsentPlanStayOnLineFirstMessageMode ReadAsPropertyName(
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
        RecordingConsentPlanStayOnLineFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
