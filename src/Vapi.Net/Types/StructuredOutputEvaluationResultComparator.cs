using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(StructuredOutputEvaluationResultComparatorSerializer))]
public enum StructuredOutputEvaluationResultComparator
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

internal class StructuredOutputEvaluationResultComparatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<StructuredOutputEvaluationResultComparator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        StructuredOutputEvaluationResultComparator
    > _stringToEnum = new()
    {
        { "=", StructuredOutputEvaluationResultComparator.EqualTo },
        { "!=", StructuredOutputEvaluationResultComparator.NotEquals },
        { ">", StructuredOutputEvaluationResultComparator.GreaterThan },
        { "<", StructuredOutputEvaluationResultComparator.LessThan },
        { ">=", StructuredOutputEvaluationResultComparator.GreaterThanOrEqualTo },
        { "<=", StructuredOutputEvaluationResultComparator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        StructuredOutputEvaluationResultComparator,
        string
    > _enumToString = new()
    {
        { StructuredOutputEvaluationResultComparator.EqualTo, "=" },
        { StructuredOutputEvaluationResultComparator.NotEquals, "!=" },
        { StructuredOutputEvaluationResultComparator.GreaterThan, ">" },
        { StructuredOutputEvaluationResultComparator.LessThan, "<" },
        { StructuredOutputEvaluationResultComparator.GreaterThanOrEqualTo, ">=" },
        { StructuredOutputEvaluationResultComparator.LessThanOrEqualTo, "<=" },
    };

    public override StructuredOutputEvaluationResultComparator Read(
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
        StructuredOutputEvaluationResultComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override StructuredOutputEvaluationResultComparator ReadAsPropertyName(
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
        StructuredOutputEvaluationResultComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
