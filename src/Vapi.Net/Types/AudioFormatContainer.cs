using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AudioFormatContainerSerializer))]
public enum AudioFormatContainer
{
    [EnumMember(Value = "raw")]
    Raw,
}

internal class AudioFormatContainerSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AudioFormatContainer>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AudioFormatContainer
    > _stringToEnum = new() { { "raw", AudioFormatContainer.Raw } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AudioFormatContainer,
        string
    > _enumToString = new() { { AudioFormatContainer.Raw, "raw" } };

    public override AudioFormatContainer Read(
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
        AudioFormatContainer value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AudioFormatContainer ReadAsPropertyName(
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
        AudioFormatContainer value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
