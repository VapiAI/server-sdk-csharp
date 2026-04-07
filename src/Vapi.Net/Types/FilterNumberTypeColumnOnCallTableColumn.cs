using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterNumberTypeColumnOnCallTableColumnSerializer))]
public enum FilterNumberTypeColumnOnCallTableColumn
{
    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,

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
}

internal class FilterNumberTypeColumnOnCallTableColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterNumberTypeColumnOnCallTableColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterNumberTypeColumnOnCallTableColumn
    > _stringToEnum = new()
    {
        { "duration", FilterNumberTypeColumnOnCallTableColumn.Duration },
        { "cost", FilterNumberTypeColumnOnCallTableColumn.Cost },
        { "averageModelLatency", FilterNumberTypeColumnOnCallTableColumn.AverageModelLatency },
        { "averageVoiceLatency", FilterNumberTypeColumnOnCallTableColumn.AverageVoiceLatency },
        {
            "averageTranscriberLatency",
            FilterNumberTypeColumnOnCallTableColumn.AverageTranscriberLatency
        },
        { "averageTurnLatency", FilterNumberTypeColumnOnCallTableColumn.AverageTurnLatency },
        {
            "averageEndpointingLatency",
            FilterNumberTypeColumnOnCallTableColumn.AverageEndpointingLatency
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterNumberTypeColumnOnCallTableColumn,
        string
    > _enumToString = new()
    {
        { FilterNumberTypeColumnOnCallTableColumn.Duration, "duration" },
        { FilterNumberTypeColumnOnCallTableColumn.Cost, "cost" },
        { FilterNumberTypeColumnOnCallTableColumn.AverageModelLatency, "averageModelLatency" },
        { FilterNumberTypeColumnOnCallTableColumn.AverageVoiceLatency, "averageVoiceLatency" },
        {
            FilterNumberTypeColumnOnCallTableColumn.AverageTranscriberLatency,
            "averageTranscriberLatency"
        },
        { FilterNumberTypeColumnOnCallTableColumn.AverageTurnLatency, "averageTurnLatency" },
        {
            FilterNumberTypeColumnOnCallTableColumn.AverageEndpointingLatency,
            "averageEndpointingLatency"
        },
    };

    public override FilterNumberTypeColumnOnCallTableColumn Read(
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
        FilterNumberTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterNumberTypeColumnOnCallTableColumn ReadAsPropertyName(
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
        FilterNumberTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
