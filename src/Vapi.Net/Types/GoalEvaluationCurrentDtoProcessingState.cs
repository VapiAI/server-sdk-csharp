using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoalEvaluationCurrentDtoProcessingStateSerializer))]
public enum GoalEvaluationCurrentDtoProcessingState
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "parked")]
    Parked,

    [EnumMember(Value = "unavailable")]
    Unavailable,

    [EnumMember(Value = "excluded")]
    Excluded,

    [EnumMember(Value = "completed")]
    Completed,
}

internal class GoalEvaluationCurrentDtoProcessingStateSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoalEvaluationCurrentDtoProcessingState>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoalEvaluationCurrentDtoProcessingState
    > _stringToEnum = new()
    {
        { "pending", GoalEvaluationCurrentDtoProcessingState.Pending },
        { "running", GoalEvaluationCurrentDtoProcessingState.Running },
        { "parked", GoalEvaluationCurrentDtoProcessingState.Parked },
        { "unavailable", GoalEvaluationCurrentDtoProcessingState.Unavailable },
        { "excluded", GoalEvaluationCurrentDtoProcessingState.Excluded },
        { "completed", GoalEvaluationCurrentDtoProcessingState.Completed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoalEvaluationCurrentDtoProcessingState,
        string
    > _enumToString = new()
    {
        { GoalEvaluationCurrentDtoProcessingState.Pending, "pending" },
        { GoalEvaluationCurrentDtoProcessingState.Running, "running" },
        { GoalEvaluationCurrentDtoProcessingState.Parked, "parked" },
        { GoalEvaluationCurrentDtoProcessingState.Unavailable, "unavailable" },
        { GoalEvaluationCurrentDtoProcessingState.Excluded, "excluded" },
        { GoalEvaluationCurrentDtoProcessingState.Completed, "completed" },
    };

    public override GoalEvaluationCurrentDtoProcessingState Read(
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
        GoalEvaluationCurrentDtoProcessingState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoalEvaluationCurrentDtoProcessingState ReadAsPropertyName(
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
        GoalEvaluationCurrentDtoProcessingState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
