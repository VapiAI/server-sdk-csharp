using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithNumberTypeColumnColumnSerializer))]
public enum JsonQueryOnCallTableWithNumberTypeColumnColumn
{
    [EnumMember(Value = "cost")]
    Cost,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "averageModelLatency")]
    AverageModelLatency,

    [EnumMember(Value = "averageVoiceLatency")]
    AverageVoiceLatency,

    [EnumMember(Value = "averageTranscriberLatency")]
    AverageTranscriberLatency,

    [EnumMember(Value = "averageTurnLatency")]
    AverageTurnLatency,

    [EnumMember(Value = "averageEndpointingLatency")]
    AverageEndpointingLatency,

    [EnumMember(Value = "artifact.structuredOutputs[OutputID]")]
    ArtifactStructuredOutputsOutputId,
}

internal class JsonQueryOnCallTableWithNumberTypeColumnColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithNumberTypeColumnColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithNumberTypeColumnColumn
    > _stringToEnum = new()
    {
        { "cost", JsonQueryOnCallTableWithNumberTypeColumnColumn.Cost },
        { "duration", JsonQueryOnCallTableWithNumberTypeColumnColumn.Duration },
        {
            "averageModelLatency",
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageModelLatency
        },
        {
            "averageVoiceLatency",
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageVoiceLatency
        },
        {
            "averageTranscriberLatency",
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageTranscriberLatency
        },
        { "averageTurnLatency", JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageTurnLatency },
        {
            "averageEndpointingLatency",
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageEndpointingLatency
        },
        {
            "artifact.structuredOutputs[OutputID]",
            JsonQueryOnCallTableWithNumberTypeColumnColumn.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithNumberTypeColumnColumn,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithNumberTypeColumnColumn.Cost, "cost" },
        { JsonQueryOnCallTableWithNumberTypeColumnColumn.Duration, "duration" },
        {
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageModelLatency,
            "averageModelLatency"
        },
        {
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageVoiceLatency,
            "averageVoiceLatency"
        },
        {
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageTranscriberLatency,
            "averageTranscriberLatency"
        },
        { JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageTurnLatency, "averageTurnLatency" },
        {
            JsonQueryOnCallTableWithNumberTypeColumnColumn.AverageEndpointingLatency,
            "averageEndpointingLatency"
        },
        {
            JsonQueryOnCallTableWithNumberTypeColumnColumn.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override JsonQueryOnCallTableWithNumberTypeColumnColumn Read(
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
        JsonQueryOnCallTableWithNumberTypeColumnColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithNumberTypeColumnColumn ReadAsPropertyName(
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
        JsonQueryOnCallTableWithNumberTypeColumnColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
