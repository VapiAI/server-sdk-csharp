using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WorkflowUserEditableVoicemailDetectionZeroSerializer))]
public enum WorkflowUserEditableVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class WorkflowUserEditableVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WorkflowUserEditableVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WorkflowUserEditableVoicemailDetectionZero
    > _stringToEnum = new() { { "off", WorkflowUserEditableVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        WorkflowUserEditableVoicemailDetectionZero,
        string
    > _enumToString = new() { { WorkflowUserEditableVoicemailDetectionZero.Off, "off" } };

    public override WorkflowUserEditableVoicemailDetectionZero Read(
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
        WorkflowUserEditableVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WorkflowUserEditableVoicemailDetectionZero ReadAsPropertyName(
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
        WorkflowUserEditableVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
