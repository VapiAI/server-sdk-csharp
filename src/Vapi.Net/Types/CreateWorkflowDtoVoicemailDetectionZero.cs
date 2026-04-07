using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateWorkflowDtoVoicemailDetectionZeroSerializer))]
public enum CreateWorkflowDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class CreateWorkflowDtoVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateWorkflowDtoVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateWorkflowDtoVoicemailDetectionZero
    > _stringToEnum = new() { { "off", CreateWorkflowDtoVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateWorkflowDtoVoicemailDetectionZero,
        string
    > _enumToString = new() { { CreateWorkflowDtoVoicemailDetectionZero.Off, "off" } };

    public override CreateWorkflowDtoVoicemailDetectionZero Read(
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
        CreateWorkflowDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateWorkflowDtoVoicemailDetectionZero ReadAsPropertyName(
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
        CreateWorkflowDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
