using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardIssueSummaryDtoStatusSerializer))]
public enum CallHealthDashboardIssueSummaryDtoStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "resolved")]
    Resolved,

    [EnumMember(Value = "dismissed")]
    Dismissed,
}

internal class CallHealthDashboardIssueSummaryDtoStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardIssueSummaryDtoStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardIssueSummaryDtoStatus
    > _stringToEnum = new()
    {
        { "active", CallHealthDashboardIssueSummaryDtoStatus.Active },
        { "resolved", CallHealthDashboardIssueSummaryDtoStatus.Resolved },
        { "dismissed", CallHealthDashboardIssueSummaryDtoStatus.Dismissed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardIssueSummaryDtoStatus,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardIssueSummaryDtoStatus.Active, "active" },
        { CallHealthDashboardIssueSummaryDtoStatus.Resolved, "resolved" },
        { CallHealthDashboardIssueSummaryDtoStatus.Dismissed, "dismissed" },
    };

    public override CallHealthDashboardIssueSummaryDtoStatus Read(
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
        CallHealthDashboardIssueSummaryDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardIssueSummaryDtoStatus ReadAsPropertyName(
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
        CallHealthDashboardIssueSummaryDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
