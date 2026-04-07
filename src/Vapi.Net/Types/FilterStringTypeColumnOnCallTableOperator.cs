using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterStringTypeColumnOnCallTableOperatorSerializer))]
public enum FilterStringTypeColumnOnCallTableOperator
{
    [EnumMember(Value = "=")]
    EqualTo,

    [EnumMember(Value = "!=")]
    NotEquals,

    [EnumMember(Value = "contains")]
    Contains,

    [EnumMember(Value = "not_contains")]
    NotContains,
}

internal class FilterStringTypeColumnOnCallTableOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterStringTypeColumnOnCallTableOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterStringTypeColumnOnCallTableOperator
    > _stringToEnum = new()
    {
        { "=", FilterStringTypeColumnOnCallTableOperator.EqualTo },
        { "!=", FilterStringTypeColumnOnCallTableOperator.NotEquals },
        { "contains", FilterStringTypeColumnOnCallTableOperator.Contains },
        { "not_contains", FilterStringTypeColumnOnCallTableOperator.NotContains },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterStringTypeColumnOnCallTableOperator,
        string
    > _enumToString = new()
    {
        { FilterStringTypeColumnOnCallTableOperator.EqualTo, "=" },
        { FilterStringTypeColumnOnCallTableOperator.NotEquals, "!=" },
        { FilterStringTypeColumnOnCallTableOperator.Contains, "contains" },
        { FilterStringTypeColumnOnCallTableOperator.NotContains, "not_contains" },
    };

    public override FilterStringTypeColumnOnCallTableOperator Read(
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
        FilterStringTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterStringTypeColumnOnCallTableOperator ReadAsPropertyName(
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
        FilterStringTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
