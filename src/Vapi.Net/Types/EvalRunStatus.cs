using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalRunStatusSerializer))]
public enum EvalRunStatus
{
    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "ended")]
    Ended,

    [EnumMember(Value = "queued")]
    Queued,
}

internal class EvalRunStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalRunStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalRunStatus
    > _stringToEnum = new()
    {
        { "running", EvalRunStatus.Running },
        { "ended", EvalRunStatus.Ended },
        { "queued", EvalRunStatus.Queued },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalRunStatus,
        string
    > _enumToString = new()
    {
        { EvalRunStatus.Running, "running" },
        { EvalRunStatus.Ended, "ended" },
        { EvalRunStatus.Queued, "queued" },
    };

    public override EvalRunStatus Read(
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
        EvalRunStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalRunStatus ReadAsPropertyName(
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
        EvalRunStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
