using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaTranscriberModelSerializer))]
public enum CartesiaTranscriberModel
{
    [EnumMember(Value = "ink-whisper")]
    InkWhisper,

    [EnumMember(Value = "ink-2")]
    Ink2,
}

internal class CartesiaTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaTranscriberModel
    > _stringToEnum = new()
    {
        { "ink-whisper", CartesiaTranscriberModel.InkWhisper },
        { "ink-2", CartesiaTranscriberModel.Ink2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaTranscriberModel,
        string
    > _enumToString = new()
    {
        { CartesiaTranscriberModel.InkWhisper, "ink-whisper" },
        { CartesiaTranscriberModel.Ink2, "ink-2" },
    };

    public override CartesiaTranscriberModel Read(
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
        CartesiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaTranscriberModel ReadAsPropertyName(
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
        CartesiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
