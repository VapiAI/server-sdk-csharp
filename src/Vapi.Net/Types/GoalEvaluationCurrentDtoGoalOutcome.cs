using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoalEvaluationCurrentDtoGoalOutcomeSerializer))]
public enum GoalEvaluationCurrentDtoGoalOutcome
{
    [EnumMember(Value = "goal_met")]
    GoalMet,

    [EnumMember(Value = "goal_not_met")]
    GoalNotMet,

    [EnumMember(Value = "not_applicable")]
    NotApplicable,
}

internal class GoalEvaluationCurrentDtoGoalOutcomeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoalEvaluationCurrentDtoGoalOutcome>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoalEvaluationCurrentDtoGoalOutcome
    > _stringToEnum = new()
    {
        { "goal_met", GoalEvaluationCurrentDtoGoalOutcome.GoalMet },
        { "goal_not_met", GoalEvaluationCurrentDtoGoalOutcome.GoalNotMet },
        { "not_applicable", GoalEvaluationCurrentDtoGoalOutcome.NotApplicable },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoalEvaluationCurrentDtoGoalOutcome,
        string
    > _enumToString = new()
    {
        { GoalEvaluationCurrentDtoGoalOutcome.GoalMet, "goal_met" },
        { GoalEvaluationCurrentDtoGoalOutcome.GoalNotMet, "goal_not_met" },
        { GoalEvaluationCurrentDtoGoalOutcome.NotApplicable, "not_applicable" },
    };

    public override GoalEvaluationCurrentDtoGoalOutcome Read(
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
        GoalEvaluationCurrentDtoGoalOutcome value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoalEvaluationCurrentDtoGoalOutcome ReadAsPropertyName(
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
        GoalEvaluationCurrentDtoGoalOutcome value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
