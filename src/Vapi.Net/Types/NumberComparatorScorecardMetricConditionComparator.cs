using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(NumberComparatorScorecardMetricConditionComparatorSerializer))]
public enum NumberComparatorScorecardMetricConditionComparator
{
    [EnumMember(Value = "=")]
    EqualTo,

    [EnumMember(Value = "!=")]
    NotEquals,

    [EnumMember(Value = ">")]
    GreaterThan,

    [EnumMember(Value = "<")]
    LessThan,

    [EnumMember(Value = ">=")]
    GreaterThanOrEqualTo,

    [EnumMember(Value = "<=")]
    LessThanOrEqualTo,
}

internal class NumberComparatorScorecardMetricConditionComparatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<NumberComparatorScorecardMetricConditionComparator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        NumberComparatorScorecardMetricConditionComparator
    > _stringToEnum = new()
    {
        { "=", NumberComparatorScorecardMetricConditionComparator.EqualTo },
        { "!=", NumberComparatorScorecardMetricConditionComparator.NotEquals },
        { ">", NumberComparatorScorecardMetricConditionComparator.GreaterThan },
        { "<", NumberComparatorScorecardMetricConditionComparator.LessThan },
        { ">=", NumberComparatorScorecardMetricConditionComparator.GreaterThanOrEqualTo },
        { "<=", NumberComparatorScorecardMetricConditionComparator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        NumberComparatorScorecardMetricConditionComparator,
        string
    > _enumToString = new()
    {
        { NumberComparatorScorecardMetricConditionComparator.EqualTo, "=" },
        { NumberComparatorScorecardMetricConditionComparator.NotEquals, "!=" },
        { NumberComparatorScorecardMetricConditionComparator.GreaterThan, ">" },
        { NumberComparatorScorecardMetricConditionComparator.LessThan, "<" },
        { NumberComparatorScorecardMetricConditionComparator.GreaterThanOrEqualTo, ">=" },
        { NumberComparatorScorecardMetricConditionComparator.LessThanOrEqualTo, "<=" },
    };

    public override NumberComparatorScorecardMetricConditionComparator Read(
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
        NumberComparatorScorecardMetricConditionComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override NumberComparatorScorecardMetricConditionComparator ReadAsPropertyName(
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
        NumberComparatorScorecardMetricConditionComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
