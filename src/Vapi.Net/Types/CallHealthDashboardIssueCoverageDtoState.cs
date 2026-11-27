using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardIssueCoverageDtoStateSerializer))]
public enum CallHealthDashboardIssueCoverageDtoState
{
    [EnumMember(Value = "complete")]
    Complete,

    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "sweeping")]
    Sweeping,

    [EnumMember(Value = "blocked")]
    Blocked,
}

internal class CallHealthDashboardIssueCoverageDtoStateSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardIssueCoverageDtoState>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardIssueCoverageDtoState
    > _stringToEnum = new()
    {
        { "complete", CallHealthDashboardIssueCoverageDtoState.Complete },
        { "partial", CallHealthDashboardIssueCoverageDtoState.Partial },
        { "sweeping", CallHealthDashboardIssueCoverageDtoState.Sweeping },
        { "blocked", CallHealthDashboardIssueCoverageDtoState.Blocked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardIssueCoverageDtoState,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardIssueCoverageDtoState.Complete, "complete" },
        { CallHealthDashboardIssueCoverageDtoState.Partial, "partial" },
        { CallHealthDashboardIssueCoverageDtoState.Sweeping, "sweeping" },
        { CallHealthDashboardIssueCoverageDtoState.Blocked, "blocked" },
    };

    public override CallHealthDashboardIssueCoverageDtoState Read(
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
        CallHealthDashboardIssueCoverageDtoState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardIssueCoverageDtoState ReadAsPropertyName(
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
        CallHealthDashboardIssueCoverageDtoState value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
