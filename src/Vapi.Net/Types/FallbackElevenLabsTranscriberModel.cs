using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackElevenLabsTranscriberModelSerializer))]
public enum FallbackElevenLabsTranscriberModel
{
    [EnumMember(Value = "scribe_v1")]
    ScribeV1,

    [EnumMember(Value = "scribe_v2")]
    ScribeV2,

    [EnumMember(Value = "scribe_v2_realtime")]
    ScribeV2Realtime,
}

internal class FallbackElevenLabsTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackElevenLabsTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackElevenLabsTranscriberModel
    > _stringToEnum = new()
    {
        { "scribe_v1", FallbackElevenLabsTranscriberModel.ScribeV1 },
        { "scribe_v2", FallbackElevenLabsTranscriberModel.ScribeV2 },
        { "scribe_v2_realtime", FallbackElevenLabsTranscriberModel.ScribeV2Realtime },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackElevenLabsTranscriberModel,
        string
    > _enumToString = new()
    {
        { FallbackElevenLabsTranscriberModel.ScribeV1, "scribe_v1" },
        { FallbackElevenLabsTranscriberModel.ScribeV2, "scribe_v2" },
        { FallbackElevenLabsTranscriberModel.ScribeV2Realtime, "scribe_v2_realtime" },
    };

    public override FallbackElevenLabsTranscriberModel Read(
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
        FallbackElevenLabsTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackElevenLabsTranscriberModel ReadAsPropertyName(
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
        FallbackElevenLabsTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
