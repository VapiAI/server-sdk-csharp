using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TalkscriberTranscriberModelSerializer))]
public enum TalkscriberTranscriberModel
{
    [EnumMember(Value = "whisper")]
    Whisper,
}

internal class TalkscriberTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TalkscriberTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TalkscriberTranscriberModel
    > _stringToEnum = new() { { "whisper", TalkscriberTranscriberModel.Whisper } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TalkscriberTranscriberModel,
        string
    > _enumToString = new() { { TalkscriberTranscriberModel.Whisper, "whisper" } };

    public override TalkscriberTranscriberModel Read(
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
        TalkscriberTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TalkscriberTranscriberModel ReadAsPropertyName(
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
        TalkscriberTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
