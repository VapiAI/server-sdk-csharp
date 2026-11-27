using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateSimulationRunResponseStatusSerializer))]
public enum CreateSimulationRunResponseStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "ended")]
    Ended,
}

internal class CreateSimulationRunResponseStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateSimulationRunResponseStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateSimulationRunResponseStatus
    > _stringToEnum = new()
    {
        { "queued", CreateSimulationRunResponseStatus.Queued },
        { "running", CreateSimulationRunResponseStatus.Running },
        { "ended", CreateSimulationRunResponseStatus.Ended },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateSimulationRunResponseStatus,
        string
    > _enumToString = new()
    {
        { CreateSimulationRunResponseStatus.Queued, "queued" },
        { CreateSimulationRunResponseStatus.Running, "running" },
        { CreateSimulationRunResponseStatus.Ended, "ended" },
    };

    public override CreateSimulationRunResponseStatus Read(
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
        CreateSimulationRunResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateSimulationRunResponseStatus ReadAsPropertyName(
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
        CreateSimulationRunResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
