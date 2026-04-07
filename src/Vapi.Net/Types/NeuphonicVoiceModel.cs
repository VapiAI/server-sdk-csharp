using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(NeuphonicVoiceModelSerializer))]
public enum NeuphonicVoiceModel
{
    [EnumMember(Value = "neu_hq")]
    NeuHq,

    [EnumMember(Value = "neu_fast")]
    NeuFast,
}

internal class NeuphonicVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<NeuphonicVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        NeuphonicVoiceModel
    > _stringToEnum = new()
    {
        { "neu_hq", NeuphonicVoiceModel.NeuHq },
        { "neu_fast", NeuphonicVoiceModel.NeuFast },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        NeuphonicVoiceModel,
        string
    > _enumToString = new()
    {
        { NeuphonicVoiceModel.NeuHq, "neu_hq" },
        { NeuphonicVoiceModel.NeuFast, "neu_fast" },
    };

    public override NeuphonicVoiceModel Read(
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
        NeuphonicVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override NeuphonicVoiceModel ReadAsPropertyName(
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
        NeuphonicVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
