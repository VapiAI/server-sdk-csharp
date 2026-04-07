using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TestSuiteTestVoiceTypeSerializer))]
public enum TestSuiteTestVoiceType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class TestSuiteTestVoiceTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TestSuiteTestVoiceType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TestSuiteTestVoiceType
    > _stringToEnum = new() { { "voice", TestSuiteTestVoiceType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TestSuiteTestVoiceType,
        string
    > _enumToString = new() { { TestSuiteTestVoiceType.Voice, "voice" } };

    public override TestSuiteTestVoiceType Read(
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
        TestSuiteTestVoiceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TestSuiteTestVoiceType ReadAsPropertyName(
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
        TestSuiteTestVoiceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
