using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GeneratedScenarioCategorySerializer))]
public enum GeneratedScenarioCategory
{
    [EnumMember(Value = "happy_path")]
    HappyPath,

    [EnumMember(Value = "edge_case")]
    EdgeCase,

    [EnumMember(Value = "failure_mode")]
    FailureMode,
}

internal class GeneratedScenarioCategorySerializer
    : global::System.Text.Json.Serialization.JsonConverter<GeneratedScenarioCategory>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GeneratedScenarioCategory
    > _stringToEnum = new()
    {
        { "happy_path", GeneratedScenarioCategory.HappyPath },
        { "edge_case", GeneratedScenarioCategory.EdgeCase },
        { "failure_mode", GeneratedScenarioCategory.FailureMode },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GeneratedScenarioCategory,
        string
    > _enumToString = new()
    {
        { GeneratedScenarioCategory.HappyPath, "happy_path" },
        { GeneratedScenarioCategory.EdgeCase, "edge_case" },
        { GeneratedScenarioCategory.FailureMode, "failure_mode" },
    };

    public override GeneratedScenarioCategory Read(
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
        GeneratedScenarioCategory value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GeneratedScenarioCategory ReadAsPropertyName(
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
        GeneratedScenarioCategory value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
