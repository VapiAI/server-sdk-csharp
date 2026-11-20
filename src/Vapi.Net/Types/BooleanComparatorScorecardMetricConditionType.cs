using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BooleanComparatorScorecardMetricConditionTypeSerializer))]
public enum BooleanComparatorScorecardMetricConditionType
{
    [EnumMember(Value = "comparator")]
    Comparator,
}

internal class BooleanComparatorScorecardMetricConditionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BooleanComparatorScorecardMetricConditionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BooleanComparatorScorecardMetricConditionType
    > _stringToEnum = new()
    {
        { "comparator", BooleanComparatorScorecardMetricConditionType.Comparator },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BooleanComparatorScorecardMetricConditionType,
        string
    > _enumToString = new()
    {
        { BooleanComparatorScorecardMetricConditionType.Comparator, "comparator" },
    };

    public override BooleanComparatorScorecardMetricConditionType Read(
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
        BooleanComparatorScorecardMetricConditionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BooleanComparatorScorecardMetricConditionType ReadAsPropertyName(
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
        BooleanComparatorScorecardMetricConditionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
