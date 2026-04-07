using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterNumberArrayTypeColumnOnCallTableColumnSerializer))]
public enum FilterNumberArrayTypeColumnOnCallTableColumn
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

internal class FilterNumberArrayTypeColumnOnCallTableColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterNumberArrayTypeColumnOnCallTableColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterNumberArrayTypeColumnOnCallTableColumn
    > _stringToEnum = new()
    {
        { "duration", FilterNumberArrayTypeColumnOnCallTableColumn.Duration },
        { "cost", FilterNumberArrayTypeColumnOnCallTableColumn.Cost },
        { "averageModelLatency", FilterNumberArrayTypeColumnOnCallTableColumn.AverageModelLatency },
        { "averageVoiceLatency", FilterNumberArrayTypeColumnOnCallTableColumn.AverageVoiceLatency },
        {
            "averageTranscriberLatency",
            FilterNumberArrayTypeColumnOnCallTableColumn.AverageTranscriberLatency
        },
        { "averageTurnLatency", FilterNumberArrayTypeColumnOnCallTableColumn.AverageTurnLatency },
        {
            "averageEndpointingLatency",
            FilterNumberArrayTypeColumnOnCallTableColumn.AverageEndpointingLatency
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterNumberArrayTypeColumnOnCallTableColumn,
        string
    > _enumToString = new()
    {
        { FilterNumberArrayTypeColumnOnCallTableColumn.Duration, "duration" },
        { FilterNumberArrayTypeColumnOnCallTableColumn.Cost, "cost" },
        { FilterNumberArrayTypeColumnOnCallTableColumn.AverageModelLatency, "averageModelLatency" },
        { FilterNumberArrayTypeColumnOnCallTableColumn.AverageVoiceLatency, "averageVoiceLatency" },
        {
            FilterNumberArrayTypeColumnOnCallTableColumn.AverageTranscriberLatency,
            "averageTranscriberLatency"
        },
        { FilterNumberArrayTypeColumnOnCallTableColumn.AverageTurnLatency, "averageTurnLatency" },
        {
            FilterNumberArrayTypeColumnOnCallTableColumn.AverageEndpointingLatency,
            "averageEndpointingLatency"
        },
    };

    public override FilterNumberArrayTypeColumnOnCallTableColumn Read(
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
        FilterNumberArrayTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterNumberArrayTypeColumnOnCallTableColumn ReadAsPropertyName(
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
        FilterNumberArrayTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
