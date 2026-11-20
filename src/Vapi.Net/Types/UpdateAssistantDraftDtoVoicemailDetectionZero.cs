using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDraftDtoVoicemailDetectionZeroSerializer))]
public enum UpdateAssistantDraftDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class UpdateAssistantDraftDtoVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDraftDtoVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDraftDtoVoicemailDetectionZero
    > _stringToEnum = new() { { "off", UpdateAssistantDraftDtoVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDraftDtoVoicemailDetectionZero,
        string
    > _enumToString = new() { { UpdateAssistantDraftDtoVoicemailDetectionZero.Off, "off" } };

    public override UpdateAssistantDraftDtoVoicemailDetectionZero Read(
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
        UpdateAssistantDraftDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDraftDtoVoicemailDetectionZero ReadAsPropertyName(
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
        UpdateAssistantDraftDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
