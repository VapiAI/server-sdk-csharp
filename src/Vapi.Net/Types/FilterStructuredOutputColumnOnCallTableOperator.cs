using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterStructuredOutputColumnOnCallTableOperatorSerializer))]
public enum FilterStructuredOutputColumnOnCallTableOperator
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

    [EnumMember(Value = "in")]
    In,

    [EnumMember(Value = "not_in")]
    NotIn,

    [EnumMember(Value = "contains")]
    Contains,

    [EnumMember(Value = "not_contains")]
    NotContains,

    [EnumMember(Value = "is_empty")]
    IsEmpty,

    [EnumMember(Value = "is_not_empty")]
    IsNotEmpty,
}

internal class FilterStructuredOutputColumnOnCallTableOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterStructuredOutputColumnOnCallTableOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterStructuredOutputColumnOnCallTableOperator
    > _stringToEnum = new()
    {
        { "=", FilterStructuredOutputColumnOnCallTableOperator.EqualTo },
        { "!=", FilterStructuredOutputColumnOnCallTableOperator.NotEquals },
        { ">", FilterStructuredOutputColumnOnCallTableOperator.GreaterThan },
        { "<", FilterStructuredOutputColumnOnCallTableOperator.LessThan },
        { ">=", FilterStructuredOutputColumnOnCallTableOperator.GreaterThanOrEqualTo },
        { "<=", FilterStructuredOutputColumnOnCallTableOperator.LessThanOrEqualTo },
        { "in", FilterStructuredOutputColumnOnCallTableOperator.In },
        { "not_in", FilterStructuredOutputColumnOnCallTableOperator.NotIn },
        { "contains", FilterStructuredOutputColumnOnCallTableOperator.Contains },
        { "not_contains", FilterStructuredOutputColumnOnCallTableOperator.NotContains },
        { "is_empty", FilterStructuredOutputColumnOnCallTableOperator.IsEmpty },
        { "is_not_empty", FilterStructuredOutputColumnOnCallTableOperator.IsNotEmpty },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterStructuredOutputColumnOnCallTableOperator,
        string
    > _enumToString = new()
    {
        { FilterStructuredOutputColumnOnCallTableOperator.EqualTo, "=" },
        { FilterStructuredOutputColumnOnCallTableOperator.NotEquals, "!=" },
        { FilterStructuredOutputColumnOnCallTableOperator.GreaterThan, ">" },
        { FilterStructuredOutputColumnOnCallTableOperator.LessThan, "<" },
        { FilterStructuredOutputColumnOnCallTableOperator.GreaterThanOrEqualTo, ">=" },
        { FilterStructuredOutputColumnOnCallTableOperator.LessThanOrEqualTo, "<=" },
        { FilterStructuredOutputColumnOnCallTableOperator.In, "in" },
        { FilterStructuredOutputColumnOnCallTableOperator.NotIn, "not_in" },
        { FilterStructuredOutputColumnOnCallTableOperator.Contains, "contains" },
        { FilterStructuredOutputColumnOnCallTableOperator.NotContains, "not_contains" },
        { FilterStructuredOutputColumnOnCallTableOperator.IsEmpty, "is_empty" },
        { FilterStructuredOutputColumnOnCallTableOperator.IsNotEmpty, "is_not_empty" },
    };

    public override FilterStructuredOutputColumnOnCallTableOperator Read(
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
        FilterStructuredOutputColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterStructuredOutputColumnOnCallTableOperator ReadAsPropertyName(
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
        FilterStructuredOutputColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
