using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AiEdgeConditionTypeSerializer))]
public enum AiEdgeConditionType
{
    [EnumMember(Value = "ai")]
    Ai,
}

internal class AiEdgeConditionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AiEdgeConditionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AiEdgeConditionType
    > _stringToEnum = new() { { "ai", AiEdgeConditionType.Ai } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AiEdgeConditionType,
        string
    > _enumToString = new() { { AiEdgeConditionType.Ai, "ai" } };

    public override AiEdgeConditionType Read(
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
        AiEdgeConditionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AiEdgeConditionType ReadAsPropertyName(
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
        AiEdgeConditionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
