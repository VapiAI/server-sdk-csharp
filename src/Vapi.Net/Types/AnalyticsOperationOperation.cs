using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnalyticsOperationOperationSerializer))]
public enum AnalyticsOperationOperation
{
    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "avg")]
    Avg,

    [EnumMember(Value = "count")]
    Count,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,

    [EnumMember(Value = "history")]
    History,
}

internal class AnalyticsOperationOperationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnalyticsOperationOperation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnalyticsOperationOperation
    > _stringToEnum = new()
    {
        { "sum", AnalyticsOperationOperation.Sum },
        { "avg", AnalyticsOperationOperation.Avg },
        { "count", AnalyticsOperationOperation.Count },
        { "min", AnalyticsOperationOperation.Min },
        { "max", AnalyticsOperationOperation.Max },
        { "history", AnalyticsOperationOperation.History },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnalyticsOperationOperation,
        string
    > _enumToString = new()
    {
        { AnalyticsOperationOperation.Sum, "sum" },
        { AnalyticsOperationOperation.Avg, "avg" },
        { AnalyticsOperationOperation.Count, "count" },
        { AnalyticsOperationOperation.Min, "min" },
        { AnalyticsOperationOperation.Max, "max" },
        { AnalyticsOperationOperation.History, "history" },
    };

    public override AnalyticsOperationOperation Read(
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
        AnalyticsOperationOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnalyticsOperationOperation ReadAsPropertyName(
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
        AnalyticsOperationOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
