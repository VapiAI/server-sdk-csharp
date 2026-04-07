using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterNumberArrayTypeColumnOnCallTableOperatorSerializer))]
public enum FilterNumberArrayTypeColumnOnCallTableOperator
{
    [EnumMember(Value = "in")]
    In,

    [EnumMember(Value = "not_in")]
    NotIn,

    [EnumMember(Value = "is_empty")]
    IsEmpty,

    [EnumMember(Value = "is_not_empty")]
    IsNotEmpty,
}

internal class FilterNumberArrayTypeColumnOnCallTableOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterNumberArrayTypeColumnOnCallTableOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterNumberArrayTypeColumnOnCallTableOperator
    > _stringToEnum = new()
    {
        { "in", FilterNumberArrayTypeColumnOnCallTableOperator.In },
        { "not_in", FilterNumberArrayTypeColumnOnCallTableOperator.NotIn },
        { "is_empty", FilterNumberArrayTypeColumnOnCallTableOperator.IsEmpty },
        { "is_not_empty", FilterNumberArrayTypeColumnOnCallTableOperator.IsNotEmpty },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterNumberArrayTypeColumnOnCallTableOperator,
        string
    > _enumToString = new()
    {
        { FilterNumberArrayTypeColumnOnCallTableOperator.In, "in" },
        { FilterNumberArrayTypeColumnOnCallTableOperator.NotIn, "not_in" },
        { FilterNumberArrayTypeColumnOnCallTableOperator.IsEmpty, "is_empty" },
        { FilterNumberArrayTypeColumnOnCallTableOperator.IsNotEmpty, "is_not_empty" },
    };

    public override FilterNumberArrayTypeColumnOnCallTableOperator Read(
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
        FilterNumberArrayTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterNumberArrayTypeColumnOnCallTableOperator ReadAsPropertyName(
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
        FilterNumberArrayTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
