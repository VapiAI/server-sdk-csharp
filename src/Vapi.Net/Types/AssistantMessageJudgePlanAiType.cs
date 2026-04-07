using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantMessageJudgePlanAiTypeSerializer))]
public enum AssistantMessageJudgePlanAiType
{
    [EnumMember(Value = "ai")]
    Ai,
}

internal class AssistantMessageJudgePlanAiTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantMessageJudgePlanAiType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantMessageJudgePlanAiType
    > _stringToEnum = new() { { "ai", AssistantMessageJudgePlanAiType.Ai } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantMessageJudgePlanAiType,
        string
    > _enumToString = new() { { AssistantMessageJudgePlanAiType.Ai, "ai" } };

    public override AssistantMessageJudgePlanAiType Read(
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
        AssistantMessageJudgePlanAiType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantMessageJudgePlanAiType ReadAsPropertyName(
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
        AssistantMessageJudgePlanAiType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
