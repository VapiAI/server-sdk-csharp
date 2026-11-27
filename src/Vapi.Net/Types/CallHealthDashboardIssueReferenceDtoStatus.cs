using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardIssueReferenceDtoStatusSerializer))]
public enum CallHealthDashboardIssueReferenceDtoStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "resolved")]
    Resolved,

    [EnumMember(Value = "dismissed")]
    Dismissed,
}

internal class CallHealthDashboardIssueReferenceDtoStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardIssueReferenceDtoStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardIssueReferenceDtoStatus
    > _stringToEnum = new()
    {
        { "active", CallHealthDashboardIssueReferenceDtoStatus.Active },
        { "resolved", CallHealthDashboardIssueReferenceDtoStatus.Resolved },
        { "dismissed", CallHealthDashboardIssueReferenceDtoStatus.Dismissed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardIssueReferenceDtoStatus,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardIssueReferenceDtoStatus.Active, "active" },
        { CallHealthDashboardIssueReferenceDtoStatus.Resolved, "resolved" },
        { CallHealthDashboardIssueReferenceDtoStatus.Dismissed, "dismissed" },
    };

    public override CallHealthDashboardIssueReferenceDtoStatus Read(
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
        CallHealthDashboardIssueReferenceDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardIssueReferenceDtoStatus ReadAsPropertyName(
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
        CallHealthDashboardIssueReferenceDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
