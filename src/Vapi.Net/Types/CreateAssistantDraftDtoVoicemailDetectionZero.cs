using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDraftDtoVoicemailDetectionZeroSerializer))]
public enum CreateAssistantDraftDtoVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class CreateAssistantDraftDtoVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDraftDtoVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDraftDtoVoicemailDetectionZero
    > _stringToEnum = new() { { "off", CreateAssistantDraftDtoVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDraftDtoVoicemailDetectionZero,
        string
    > _enumToString = new() { { CreateAssistantDraftDtoVoicemailDetectionZero.Off, "off" } };

    public override CreateAssistantDraftDtoVoicemailDetectionZero Read(
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
        CreateAssistantDraftDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDraftDtoVoicemailDetectionZero ReadAsPropertyName(
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
        CreateAssistantDraftDtoVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
