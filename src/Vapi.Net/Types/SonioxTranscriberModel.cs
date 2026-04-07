using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SonioxTranscriberModelSerializer))]
public enum SonioxTranscriberModel
{
    [EnumMember(Value = "stt-rt-v4")]
    SttRtV4,
}

internal class SonioxTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SonioxTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SonioxTranscriberModel
    > _stringToEnum = new() { { "stt-rt-v4", SonioxTranscriberModel.SttRtV4 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SonioxTranscriberModel,
        string
    > _enumToString = new() { { SonioxTranscriberModel.SttRtV4, "stt-rt-v4" } };

    public override SonioxTranscriberModel Read(
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
        SonioxTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SonioxTranscriberModel ReadAsPropertyName(
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
        SonioxTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
