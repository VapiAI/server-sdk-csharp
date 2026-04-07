using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TestSuiteRunStatusSerializer))]
public enum TestSuiteRunStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "failed")]
    Failed,
}

internal class TestSuiteRunStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TestSuiteRunStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TestSuiteRunStatus
    > _stringToEnum = new()
    {
        { "queued", TestSuiteRunStatus.Queued },
        { "in-progress", TestSuiteRunStatus.InProgress },
        { "completed", TestSuiteRunStatus.Completed },
        { "failed", TestSuiteRunStatus.Failed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TestSuiteRunStatus,
        string
    > _enumToString = new()
    {
        { TestSuiteRunStatus.Queued, "queued" },
        { TestSuiteRunStatus.InProgress, "in-progress" },
        { TestSuiteRunStatus.Completed, "completed" },
        { TestSuiteRunStatus.Failed, "failed" },
    };

    public override TestSuiteRunStatus Read(
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
        TestSuiteRunStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TestSuiteRunStatus ReadAsPropertyName(
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
        TestSuiteRunStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
