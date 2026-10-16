using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantDraftVoicemailDetectionZeroSerializer))]
public enum AssistantDraftVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class AssistantDraftVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantDraftVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantDraftVoicemailDetectionZero
    > _stringToEnum = new() { { "off", AssistantDraftVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantDraftVoicemailDetectionZero,
        string
    > _enumToString = new() { { AssistantDraftVoicemailDetectionZero.Off, "off" } };

    public override AssistantDraftVoicemailDetectionZero Read(
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
        AssistantDraftVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantDraftVoicemailDetectionZero ReadAsPropertyName(
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
        AssistantDraftVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
