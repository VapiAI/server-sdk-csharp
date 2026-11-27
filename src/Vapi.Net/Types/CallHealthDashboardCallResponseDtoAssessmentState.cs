using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardCallResponseDtoAssessmentStateSerializer))]
public enum CallHealthDashboardCallResponseDtoAssessmentState
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "unavailable")]
    Unavailable,

    [EnumMember(Value = "skipped")]
    Skipped,

    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "excluded")]
    Excluded,

    [EnumMember(Value = "complete")]
    Complete,

    [EnumMember(Value = "partial")]
    Partial,
}

internal class CallHealthDashboardCallResponseDtoAssessmentStateSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardCallResponseDtoAssessmentState>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardCallResponseDtoAssessmentState
    > _stringToEnum = new()
    {
        { "pending", CallHealthDashboardCallResponseDtoAssessmentState.Pending },
        { "unavailable", CallHealthDashboardCallResponseDtoAssessmentState.Unavailable },
        { "skipped", CallHealthDashboardCallResponseDtoAssessmentState.Skipped },
        { "error", CallHealthDashboardCallResponseDtoAssessmentState.Error },
        { "excluded", CallHealthDashboardCallResponseDtoAssessmentState.Excluded },
        { "complete", CallHealthDashboardCallResponseDtoAssessmentState.Complete },
        { "partial", CallHealthDashboardCallResponseDtoAssessmentState.Partial },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardCallResponseDtoAssessmentState,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardCallResponseDtoAssessmentState.Pending, "pending" },
        { CallHealthDashboardCallResponseDtoAssessmentState.Unavailable, "unavailable" },
        { CallHealthDashboardCallResponseDtoAssessmentState.Skipped, "skipped" },
        { CallHealthDashboardCallResponseDtoAssessmentState.Error, "error" },
        { CallHealthDashboardCallResponseDtoAssessmentState.Excluded, "excluded" },
        { CallHealthDashboardCallResponseDtoAssessmentState.Complete, "complete" },
        { CallHealthDashboardCallResponseDtoAssessmentState.Partial, "partial" },
    };

    public override CallHealthDashboardCallResponseDtoAssessmentState Read(
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
        CallHealthDashboardCallResponseDtoAssessmentState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardCallResponseDtoAssessmentState ReadAsPropertyName(
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
        CallHealthDashboardCallResponseDtoAssessmentState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
