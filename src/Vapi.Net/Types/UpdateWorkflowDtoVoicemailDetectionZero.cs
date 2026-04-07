using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateWorkflowDtoVoicemailDetectionZeroSerializer))]
public enum UpdateWorkflowDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class UpdateWorkflowDtoVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateWorkflowDtoVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateWorkflowDtoVoicemailDetectionZero
    > _stringToEnum = new() { { "off", UpdateWorkflowDtoVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateWorkflowDtoVoicemailDetectionZero,
        string
    > _enumToString = new() { { UpdateWorkflowDtoVoicemailDetectionZero.Off, "off" } };

    public override UpdateWorkflowDtoVoicemailDetectionZero Read(
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
        UpdateWorkflowDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateWorkflowDtoVoicemailDetectionZero ReadAsPropertyName(
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
        UpdateWorkflowDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
