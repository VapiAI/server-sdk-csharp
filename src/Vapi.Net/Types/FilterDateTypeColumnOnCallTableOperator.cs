using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterDateTypeColumnOnCallTableOperatorSerializer))]
public enum FilterDateTypeColumnOnCallTableOperator
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

internal class FilterDateTypeColumnOnCallTableOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterDateTypeColumnOnCallTableOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterDateTypeColumnOnCallTableOperator
    > _stringToEnum = new()
    {
        { "=", FilterDateTypeColumnOnCallTableOperator.EqualTo },
        { "!=", FilterDateTypeColumnOnCallTableOperator.NotEquals },
        { ">", FilterDateTypeColumnOnCallTableOperator.GreaterThan },
        { "<", FilterDateTypeColumnOnCallTableOperator.LessThan },
        { ">=", FilterDateTypeColumnOnCallTableOperator.GreaterThanOrEqualTo },
        { "<=", FilterDateTypeColumnOnCallTableOperator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterDateTypeColumnOnCallTableOperator,
        string
    > _enumToString = new()
    {
        { FilterDateTypeColumnOnCallTableOperator.EqualTo, "=" },
        { FilterDateTypeColumnOnCallTableOperator.NotEquals, "!=" },
        { FilterDateTypeColumnOnCallTableOperator.GreaterThan, ">" },
        { FilterDateTypeColumnOnCallTableOperator.LessThan, "<" },
        { FilterDateTypeColumnOnCallTableOperator.GreaterThanOrEqualTo, ">=" },
        { FilterDateTypeColumnOnCallTableOperator.LessThanOrEqualTo, "<=" },
    };

    public override FilterDateTypeColumnOnCallTableOperator Read(
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
        FilterDateTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterDateTypeColumnOnCallTableOperator ReadAsPropertyName(
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
        FilterDateTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
