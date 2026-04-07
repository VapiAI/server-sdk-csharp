using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvaluationPlanItemComparatorSerializer))]
public enum EvaluationPlanItemComparator
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

internal class EvaluationPlanItemComparatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvaluationPlanItemComparator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvaluationPlanItemComparator
    > _stringToEnum = new()
    {
        { "=", EvaluationPlanItemComparator.EqualTo },
        { "!=", EvaluationPlanItemComparator.NotEquals },
        { ">", EvaluationPlanItemComparator.GreaterThan },
        { "<", EvaluationPlanItemComparator.LessThan },
        { ">=", EvaluationPlanItemComparator.GreaterThanOrEqualTo },
        { "<=", EvaluationPlanItemComparator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvaluationPlanItemComparator,
        string
    > _enumToString = new()
    {
        { EvaluationPlanItemComparator.EqualTo, "=" },
        { EvaluationPlanItemComparator.NotEquals, "!=" },
        { EvaluationPlanItemComparator.GreaterThan, ">" },
        { EvaluationPlanItemComparator.LessThan, "<" },
        { EvaluationPlanItemComparator.GreaterThanOrEqualTo, ">=" },
        { EvaluationPlanItemComparator.LessThanOrEqualTo, "<=" },
    };

    public override EvaluationPlanItemComparator Read(
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
        EvaluationPlanItemComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvaluationPlanItemComparator ReadAsPropertyName(
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
        EvaluationPlanItemComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
