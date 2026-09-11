using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EndedReasonConditionOperatorSerializer))]
public enum EndedReasonConditionOperator
{
    [EnumMember(Value = "oneOf")]
    OneOf,

    [EnumMember(Value = "notOneOf")]
    NotOneOf,
}

internal class EndedReasonConditionOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EndedReasonConditionOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EndedReasonConditionOperator
    > _stringToEnum = new()
    {
        { "oneOf", EndedReasonConditionOperator.OneOf },
        { "notOneOf", EndedReasonConditionOperator.NotOneOf },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EndedReasonConditionOperator,
        string
    > _enumToString = new()
    {
        { EndedReasonConditionOperator.OneOf, "oneOf" },
        { EndedReasonConditionOperator.NotOneOf, "notOneOf" },
    };

    public override EndedReasonConditionOperator Read(
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
        EndedReasonConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EndedReasonConditionOperator ReadAsPropertyName(
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
        EndedReasonConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
