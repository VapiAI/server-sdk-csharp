using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TestSuiteRunScorerAiTypeSerializer))]
public enum TestSuiteRunScorerAiType
{
    [EnumMember(Value = "ai")]
    Ai,
}

internal class TestSuiteRunScorerAiTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TestSuiteRunScorerAiType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TestSuiteRunScorerAiType
    > _stringToEnum = new() { { "ai", TestSuiteRunScorerAiType.Ai } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TestSuiteRunScorerAiType,
        string
    > _enumToString = new() { { TestSuiteRunScorerAiType.Ai, "ai" } };

    public override TestSuiteRunScorerAiType Read(
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
        TestSuiteRunScorerAiType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TestSuiteRunScorerAiType ReadAsPropertyName(
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
        TestSuiteRunScorerAiType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
