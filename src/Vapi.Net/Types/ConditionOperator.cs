using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ConditionOperatorSerializer))]
public enum ConditionOperator
{
    [EnumMember(Value = "eq")]
    Eq,

    [EnumMember(Value = "neq")]
    Neq,

    [EnumMember(Value = "gt")]
    Gt,

    [EnumMember(Value = "gte")]
    Gte,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lte")]
    Lte,
}

internal class ConditionOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ConditionOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ConditionOperator
    > _stringToEnum = new()
    {
        { "eq", ConditionOperator.Eq },
        { "neq", ConditionOperator.Neq },
        { "gt", ConditionOperator.Gt },
        { "gte", ConditionOperator.Gte },
        { "lt", ConditionOperator.Lt },
        { "lte", ConditionOperator.Lte },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ConditionOperator,
        string
    > _enumToString = new()
    {
        { ConditionOperator.Eq, "eq" },
        { ConditionOperator.Neq, "neq" },
        { ConditionOperator.Gt, "gt" },
        { ConditionOperator.Gte, "gte" },
        { ConditionOperator.Lt, "lt" },
        { ConditionOperator.Lte, "lte" },
    };

    public override ConditionOperator Read(
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
        ConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ConditionOperator ReadAsPropertyName(
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
        ConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
