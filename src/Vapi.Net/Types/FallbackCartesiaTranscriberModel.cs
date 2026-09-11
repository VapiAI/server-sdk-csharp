using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackCartesiaTranscriberModelSerializer))]
public enum FallbackCartesiaTranscriberModel
{
    [EnumMember(Value = "ink-whisper")]
    InkWhisper,

    [EnumMember(Value = "ink-2")]
    Ink2,
}

internal class FallbackCartesiaTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackCartesiaTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackCartesiaTranscriberModel
    > _stringToEnum = new()
    {
        { "ink-whisper", FallbackCartesiaTranscriberModel.InkWhisper },
        { "ink-2", FallbackCartesiaTranscriberModel.Ink2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackCartesiaTranscriberModel,
        string
    > _enumToString = new()
    {
        { FallbackCartesiaTranscriberModel.InkWhisper, "ink-whisper" },
        { FallbackCartesiaTranscriberModel.Ink2, "ink-2" },
    };

    public override FallbackCartesiaTranscriberModel Read(
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
        FallbackCartesiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackCartesiaTranscriberModel ReadAsPropertyName(
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
        FallbackCartesiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
