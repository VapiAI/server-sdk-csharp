using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TestSuiteRunScorerAiResultSerializer))]
public enum TestSuiteRunScorerAiResult
{
    [EnumMember(Value = "pass")]
    Pass,

    [EnumMember(Value = "fail")]
    Fail,
}

internal class TestSuiteRunScorerAiResultSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TestSuiteRunScorerAiResult>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TestSuiteRunScorerAiResult
    > _stringToEnum = new()
    {
        { "pass", TestSuiteRunScorerAiResult.Pass },
        { "fail", TestSuiteRunScorerAiResult.Fail },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TestSuiteRunScorerAiResult,
        string
    > _enumToString = new()
    {
        { TestSuiteRunScorerAiResult.Pass, "pass" },
        { TestSuiteRunScorerAiResult.Fail, "fail" },
    };

    public override TestSuiteRunScorerAiResult Read(
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
        TestSuiteRunScorerAiResult value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TestSuiteRunScorerAiResult ReadAsPropertyName(
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
        TestSuiteRunScorerAiResult value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
