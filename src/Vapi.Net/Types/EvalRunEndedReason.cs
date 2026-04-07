using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalRunEndedReasonSerializer))]
public enum EvalRunEndedReason
{
    [EnumMember(Value = "mockConversation.done")]
    MockConversationDone,

    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "timeout")]
    Timeout,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "aborted")]
    Aborted,
}

internal class EvalRunEndedReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalRunEndedReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalRunEndedReason
    > _stringToEnum = new()
    {
        { "mockConversation.done", EvalRunEndedReason.MockConversationDone },
        { "error", EvalRunEndedReason.Error },
        { "timeout", EvalRunEndedReason.Timeout },
        { "cancelled", EvalRunEndedReason.Cancelled },
        { "aborted", EvalRunEndedReason.Aborted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalRunEndedReason,
        string
    > _enumToString = new()
    {
        { EvalRunEndedReason.MockConversationDone, "mockConversation.done" },
        { EvalRunEndedReason.Error, "error" },
        { EvalRunEndedReason.Timeout, "timeout" },
        { EvalRunEndedReason.Cancelled, "cancelled" },
        { EvalRunEndedReason.Aborted, "aborted" },
    };

    public override EvalRunEndedReason Read(
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
        EvalRunEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalRunEndedReason ReadAsPropertyName(
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
        EvalRunEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
