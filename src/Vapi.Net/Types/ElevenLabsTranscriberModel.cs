using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsTranscriberModelSerializer))]
public enum ElevenLabsTranscriberModel
{
    [EnumMember(Value = "scribe_v1")]
    ScribeV1,

    [EnumMember(Value = "scribe_v2")]
    ScribeV2,

    [EnumMember(Value = "scribe_v2_realtime")]
    ScribeV2Realtime,
}

internal class ElevenLabsTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsTranscriberModel
    > _stringToEnum = new()
    {
        { "scribe_v1", ElevenLabsTranscriberModel.ScribeV1 },
        { "scribe_v2", ElevenLabsTranscriberModel.ScribeV2 },
        { "scribe_v2_realtime", ElevenLabsTranscriberModel.ScribeV2Realtime },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsTranscriberModel,
        string
    > _enumToString = new()
    {
        { ElevenLabsTranscriberModel.ScribeV1, "scribe_v1" },
        { ElevenLabsTranscriberModel.ScribeV2, "scribe_v2" },
        { ElevenLabsTranscriberModel.ScribeV2Realtime, "scribe_v2_realtime" },
    };

    public override ElevenLabsTranscriberModel Read(
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
        ElevenLabsTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsTranscriberModel ReadAsPropertyName(
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
        ElevenLabsTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
