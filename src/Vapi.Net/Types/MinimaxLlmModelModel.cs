using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MinimaxLlmModelModelSerializer))]
public enum MinimaxLlmModelModel
{
    [EnumMember(Value = "MiniMax-M2.7")]
    MiniMaxM27,
}

internal class MinimaxLlmModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MinimaxLlmModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MinimaxLlmModelModel
    > _stringToEnum = new() { { "MiniMax-M2.7", MinimaxLlmModelModel.MiniMaxM27 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        MinimaxLlmModelModel,
        string
    > _enumToString = new() { { MinimaxLlmModelModel.MiniMaxM27, "MiniMax-M2.7" } };

    public override MinimaxLlmModelModel Read(
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
        MinimaxLlmModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MinimaxLlmModelModel ReadAsPropertyName(
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
        MinimaxLlmModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
