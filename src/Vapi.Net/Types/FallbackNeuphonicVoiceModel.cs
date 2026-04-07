using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackNeuphonicVoiceModelSerializer))]
public enum FallbackNeuphonicVoiceModel
{
    [EnumMember(Value = "neu_hq")]
    NeuHq,

    [EnumMember(Value = "neu_fast")]
    NeuFast,
}

internal class FallbackNeuphonicVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackNeuphonicVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackNeuphonicVoiceModel
    > _stringToEnum = new()
    {
        { "neu_hq", FallbackNeuphonicVoiceModel.NeuHq },
        { "neu_fast", FallbackNeuphonicVoiceModel.NeuFast },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackNeuphonicVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackNeuphonicVoiceModel.NeuHq, "neu_hq" },
        { FallbackNeuphonicVoiceModel.NeuFast, "neu_fast" },
    };

    public override FallbackNeuphonicVoiceModel Read(
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
        FallbackNeuphonicVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackNeuphonicVoiceModel ReadAsPropertyName(
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
        FallbackNeuphonicVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
