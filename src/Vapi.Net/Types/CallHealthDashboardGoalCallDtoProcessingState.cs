using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardGoalCallDtoProcessingStateSerializer))]
public enum CallHealthDashboardGoalCallDtoProcessingState
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

internal class CallHealthDashboardGoalCallDtoProcessingStateSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardGoalCallDtoProcessingState>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardGoalCallDtoProcessingState
    > _stringToEnum = new()
    {
        { "pending", CallHealthDashboardGoalCallDtoProcessingState.Pending },
        { "running", CallHealthDashboardGoalCallDtoProcessingState.Running },
        { "parked", CallHealthDashboardGoalCallDtoProcessingState.Parked },
        { "unavailable", CallHealthDashboardGoalCallDtoProcessingState.Unavailable },
        { "excluded", CallHealthDashboardGoalCallDtoProcessingState.Excluded },
        { "completed", CallHealthDashboardGoalCallDtoProcessingState.Completed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardGoalCallDtoProcessingState,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardGoalCallDtoProcessingState.Pending, "pending" },
        { CallHealthDashboardGoalCallDtoProcessingState.Running, "running" },
        { CallHealthDashboardGoalCallDtoProcessingState.Parked, "parked" },
        { CallHealthDashboardGoalCallDtoProcessingState.Unavailable, "unavailable" },
        { CallHealthDashboardGoalCallDtoProcessingState.Excluded, "excluded" },
        { CallHealthDashboardGoalCallDtoProcessingState.Completed, "completed" },
    };

    public override CallHealthDashboardGoalCallDtoProcessingState Read(
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
        CallHealthDashboardGoalCallDtoProcessingState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardGoalCallDtoProcessingState ReadAsPropertyName(
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
        CallHealthDashboardGoalCallDtoProcessingState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
