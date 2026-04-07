using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSonioxTranscriberModelSerializer))]
public enum FallbackSonioxTranscriberModel
{
    [EnumMember(Value = "stt-rt-v4")]
    SttRtV4,
}

internal class FallbackSonioxTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSonioxTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSonioxTranscriberModel
    > _stringToEnum = new() { { "stt-rt-v4", FallbackSonioxTranscriberModel.SttRtV4 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSonioxTranscriberModel,
        string
    > _enumToString = new() { { FallbackSonioxTranscriberModel.SttRtV4, "stt-rt-v4" } };

    public override FallbackSonioxTranscriberModel Read(
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
        FallbackSonioxTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSonioxTranscriberModel ReadAsPropertyName(
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
        FallbackSonioxTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
