using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardIssueActivityDtoActionSerializer))]
public enum CallHealthDashboardIssueActivityDtoAction
{
    [EnumMember(Value = "resolve")]
    Resolve,

    [EnumMember(Value = "dismiss")]
    Dismiss,

    [EnumMember(Value = "restore")]
    Restore,

    [EnumMember(Value = "reopen")]
    Reopen,
}

internal class CallHealthDashboardIssueActivityDtoActionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardIssueActivityDtoAction>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardIssueActivityDtoAction
    > _stringToEnum = new()
    {
        { "resolve", CallHealthDashboardIssueActivityDtoAction.Resolve },
        { "dismiss", CallHealthDashboardIssueActivityDtoAction.Dismiss },
        { "restore", CallHealthDashboardIssueActivityDtoAction.Restore },
        { "reopen", CallHealthDashboardIssueActivityDtoAction.Reopen },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardIssueActivityDtoAction,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardIssueActivityDtoAction.Resolve, "resolve" },
        { CallHealthDashboardIssueActivityDtoAction.Dismiss, "dismiss" },
        { CallHealthDashboardIssueActivityDtoAction.Restore, "restore" },
        { CallHealthDashboardIssueActivityDtoAction.Reopen, "reopen" },
    };

    public override CallHealthDashboardIssueActivityDtoAction Read(
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
        CallHealthDashboardIssueActivityDtoAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardIssueActivityDtoAction ReadAsPropertyName(
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
        CallHealthDashboardIssueActivityDtoAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
