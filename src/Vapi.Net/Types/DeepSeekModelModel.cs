using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepSeekModelModelSerializer))]
public enum DeepSeekModelModel
{
    [EnumMember(Value = "deepseek-chat")]
    DeepseekChat,

    [EnumMember(Value = "deepseek-reasoner")]
    DeepseekReasoner,
}

internal class DeepSeekModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepSeekModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepSeekModelModel
    > _stringToEnum = new()
    {
        { "deepseek-chat", DeepSeekModelModel.DeepseekChat },
        { "deepseek-reasoner", DeepSeekModelModel.DeepseekReasoner },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepSeekModelModel,
        string
    > _enumToString = new()
    {
        { DeepSeekModelModel.DeepseekChat, "deepseek-chat" },
        { DeepSeekModelModel.DeepseekReasoner, "deepseek-reasoner" },
    };

    public override DeepSeekModelModel Read(
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
        DeepSeekModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepSeekModelModel ReadAsPropertyName(
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
        DeepSeekModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
