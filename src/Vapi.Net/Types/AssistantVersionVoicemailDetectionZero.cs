using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantVersionVoicemailDetectionZeroSerializer))]
public enum AssistantVersionVoicemailDetectionZero
{
    [EnumMember(Value = "off")]
    Off,
}

internal class AssistantVersionVoicemailDetectionZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantVersionVoicemailDetectionZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantVersionVoicemailDetectionZero
    > _stringToEnum = new() { { "off", AssistantVersionVoicemailDetectionZero.Off } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantVersionVoicemailDetectionZero,
        string
    > _enumToString = new() { { AssistantVersionVoicemailDetectionZero.Off, "off" } };

    public override AssistantVersionVoicemailDetectionZero Read(
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
        AssistantVersionVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantVersionVoicemailDetectionZero ReadAsPropertyName(
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
        AssistantVersionVoicemailDetectionZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
