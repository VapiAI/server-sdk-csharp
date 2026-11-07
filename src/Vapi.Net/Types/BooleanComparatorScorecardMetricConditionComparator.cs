using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BooleanComparatorScorecardMetricConditionComparatorSerializer))]
public enum BooleanComparatorScorecardMetricConditionComparator
{
    [EnumMember(Value = "=")]
    EqualTo,
}

internal class BooleanComparatorScorecardMetricConditionComparatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BooleanComparatorScorecardMetricConditionComparator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BooleanComparatorScorecardMetricConditionComparator
    > _stringToEnum = new()
    {
        { "=", BooleanComparatorScorecardMetricConditionComparator.EqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BooleanComparatorScorecardMetricConditionComparator,
        string
    > _enumToString = new()
    {
        { BooleanComparatorScorecardMetricConditionComparator.EqualTo, "=" },
    };

    public override BooleanComparatorScorecardMetricConditionComparator Read(
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
        BooleanComparatorScorecardMetricConditionComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BooleanComparatorScorecardMetricConditionComparator ReadAsPropertyName(
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
        BooleanComparatorScorecardMetricConditionComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
