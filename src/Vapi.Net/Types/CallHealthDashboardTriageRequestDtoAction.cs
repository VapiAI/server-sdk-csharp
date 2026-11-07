using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardTriageRequestDtoActionSerializer))]
public enum CallHealthDashboardTriageRequestDtoAction
{
    [EnumMember(Value = "resolve")]
    Resolve,

    [EnumMember(Value = "dismiss")]
    Dismiss,

    [EnumMember(Value = "restore")]
    Restore,
}

internal class CallHealthDashboardTriageRequestDtoActionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardTriageRequestDtoAction>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardTriageRequestDtoAction
    > _stringToEnum = new()
    {
        { "resolve", CallHealthDashboardTriageRequestDtoAction.Resolve },
        { "dismiss", CallHealthDashboardTriageRequestDtoAction.Dismiss },
        { "restore", CallHealthDashboardTriageRequestDtoAction.Restore },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardTriageRequestDtoAction,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardTriageRequestDtoAction.Resolve, "resolve" },
        { CallHealthDashboardTriageRequestDtoAction.Dismiss, "dismiss" },
        { CallHealthDashboardTriageRequestDtoAction.Restore, "restore" },
    };

    public override CallHealthDashboardTriageRequestDtoAction Read(
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
        CallHealthDashboardTriageRequestDtoAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardTriageRequestDtoAction ReadAsPropertyName(
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
        CallHealthDashboardTriageRequestDtoAction value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
