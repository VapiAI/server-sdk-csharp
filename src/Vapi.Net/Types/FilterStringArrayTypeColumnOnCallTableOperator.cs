using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterStringArrayTypeColumnOnCallTableOperatorSerializer))]
public enum FilterStringArrayTypeColumnOnCallTableOperator
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

internal class FilterStringArrayTypeColumnOnCallTableOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterStringArrayTypeColumnOnCallTableOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterStringArrayTypeColumnOnCallTableOperator
    > _stringToEnum = new()
    {
        { "in", FilterStringArrayTypeColumnOnCallTableOperator.In },
        { "not_in", FilterStringArrayTypeColumnOnCallTableOperator.NotIn },
        { "is_empty", FilterStringArrayTypeColumnOnCallTableOperator.IsEmpty },
        { "is_not_empty", FilterStringArrayTypeColumnOnCallTableOperator.IsNotEmpty },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterStringArrayTypeColumnOnCallTableOperator,
        string
    > _enumToString = new()
    {
        { FilterStringArrayTypeColumnOnCallTableOperator.In, "in" },
        { FilterStringArrayTypeColumnOnCallTableOperator.NotIn, "not_in" },
        { FilterStringArrayTypeColumnOnCallTableOperator.IsEmpty, "is_empty" },
        { FilterStringArrayTypeColumnOnCallTableOperator.IsNotEmpty, "is_not_empty" },
    };

    public override FilterStringArrayTypeColumnOnCallTableOperator Read(
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
        FilterStringArrayTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterStringArrayTypeColumnOnCallTableOperator ReadAsPropertyName(
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
        FilterStringArrayTypeColumnOnCallTableOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
