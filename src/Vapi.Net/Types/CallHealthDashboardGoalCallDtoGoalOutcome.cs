using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardGoalCallDtoGoalOutcomeSerializer))]
public enum CallHealthDashboardGoalCallDtoGoalOutcome
{
    [EnumMember(Value = "goal_met")]
    GoalMet,

    [EnumMember(Value = "goal_not_met")]
    GoalNotMet,

    [EnumMember(Value = "not_applicable")]
    NotApplicable,
}

internal class CallHealthDashboardGoalCallDtoGoalOutcomeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardGoalCallDtoGoalOutcome>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardGoalCallDtoGoalOutcome
    > _stringToEnum = new()
    {
        { "goal_met", CallHealthDashboardGoalCallDtoGoalOutcome.GoalMet },
        { "goal_not_met", CallHealthDashboardGoalCallDtoGoalOutcome.GoalNotMet },
        { "not_applicable", CallHealthDashboardGoalCallDtoGoalOutcome.NotApplicable },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardGoalCallDtoGoalOutcome,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardGoalCallDtoGoalOutcome.GoalMet, "goal_met" },
        { CallHealthDashboardGoalCallDtoGoalOutcome.GoalNotMet, "goal_not_met" },
        { CallHealthDashboardGoalCallDtoGoalOutcome.NotApplicable, "not_applicable" },
    };

    public override CallHealthDashboardGoalCallDtoGoalOutcome Read(
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
        CallHealthDashboardGoalCallDtoGoalOutcome value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardGoalCallDtoGoalOutcome ReadAsPropertyName(
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
        CallHealthDashboardGoalCallDtoGoalOutcome value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
