using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BoardMetricWidgetItemTypeSerializer))]
public enum BoardMetricWidgetItemType
{
    [EnumMember(Value = "failed_calls_list")]
    FailedCallsList,

    [EnumMember(Value = "concurrency_chart")]
    ConcurrencyChart,

    [EnumMember(Value = "average_cost_breakdown_chart")]
    AverageCostBreakdownChart,
}

internal class BoardMetricWidgetItemTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BoardMetricWidgetItemType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BoardMetricWidgetItemType
    > _stringToEnum = new()
    {
        { "failed_calls_list", BoardMetricWidgetItemType.FailedCallsList },
        { "concurrency_chart", BoardMetricWidgetItemType.ConcurrencyChart },
        { "average_cost_breakdown_chart", BoardMetricWidgetItemType.AverageCostBreakdownChart },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BoardMetricWidgetItemType,
        string
    > _enumToString = new()
    {
        { BoardMetricWidgetItemType.FailedCallsList, "failed_calls_list" },
        { BoardMetricWidgetItemType.ConcurrencyChart, "concurrency_chart" },
        { BoardMetricWidgetItemType.AverageCostBreakdownChart, "average_cost_breakdown_chart" },
    };

    public override BoardMetricWidgetItemType Read(
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
        BoardMetricWidgetItemType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BoardMetricWidgetItemType ReadAsPropertyName(
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
        BoardMetricWidgetItemType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
