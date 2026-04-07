using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SmallestAiVoiceModelSerializer))]
public enum SmallestAiVoiceModel
{
    [EnumMember(Value = "lightning")]
    Lightning,
}

internal class SmallestAiVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SmallestAiVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SmallestAiVoiceModel
    > _stringToEnum = new() { { "lightning", SmallestAiVoiceModel.Lightning } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SmallestAiVoiceModel,
        string
    > _enumToString = new() { { SmallestAiVoiceModel.Lightning, "lightning" } };

    public override SmallestAiVoiceModel Read(
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
        SmallestAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SmallestAiVoiceModel ReadAsPropertyName(
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
        SmallestAiVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
