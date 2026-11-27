using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantSaveResponseVoicemailDetectionZeroSerializer))]
public enum AssistantSaveResponseVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class AssistantSaveResponseVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantSaveResponseVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantSaveResponseVoicemailDetectionZero
    > _stringToEnum = new() { { "off", AssistantSaveResponseVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantSaveResponseVoicemailDetectionZero,
        string
    > _enumToString = new() { { AssistantSaveResponseVoicemailDetectionZero.Off, "off" } };

    public override AssistantSaveResponseVoicemailDetectionZero Read(
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
        AssistantSaveResponseVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantSaveResponseVoicemailDetectionZero ReadAsPropertyName(
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
        AssistantSaveResponseVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
