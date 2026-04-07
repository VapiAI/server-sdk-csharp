using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterNumberTypeColumnOnCallTableOperatorSerializer))]
public enum FilterNumberTypeColumnOnCallTableOperator
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

internal class FilterNumberTypeColumnOnCallTableOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterNumberTypeColumnOnCallTableOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterNumberTypeColumnOnCallTableOperator
    > _stringToEnum = new()
    {
        { "=", FilterNumberTypeColumnOnCallTableOperator.EqualTo },
        { "!=", FilterNumberTypeColumnOnCallTableOperator.NotEquals },
        { ">", FilterNumberTypeColumnOnCallTableOperator.GreaterThan },
        { "<", FilterNumberTypeColumnOnCallTableOperator.LessThan },
        { ">=", FilterNumberTypeColumnOnCallTableOperator.GreaterThanOrEqualTo },
        { "<=", FilterNumberTypeColumnOnCallTableOperator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterNumberTypeColumnOnCallTableOperator,
        string
    > _enumToString = new()
    {
        { FilterNumberTypeColumnOnCallTableOperator.EqualTo, "=" },
        { FilterNumberTypeColumnOnCallTableOperator.NotEquals, "!=" },
        { FilterNumberTypeColumnOnCallTableOperator.GreaterThan, ">" },
        { FilterNumberTypeColumnOnCallTableOperator.LessThan, "<" },
        { FilterNumberTypeColumnOnCallTableOperator.GreaterThanOrEqualTo, ">=" },
        { FilterNumberTypeColumnOnCallTableOperator.LessThanOrEqualTo, "<=" },
    };

    public override FilterNumberTypeColumnOnCallTableOperator Read(
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
        FilterNumberTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterNumberTypeColumnOnCallTableOperator ReadAsPropertyName(
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
        FilterNumberTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
