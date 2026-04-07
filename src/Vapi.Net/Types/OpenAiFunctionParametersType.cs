using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiFunctionParametersTypeSerializer))]
public enum OpenAiFunctionParametersType
{
    [EnumMember(Value = "object")]
    Object,
}

internal class OpenAiFunctionParametersTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiFunctionParametersType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiFunctionParametersType
    > _stringToEnum = new() { { "object", OpenAiFunctionParametersType.Object } };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiFunctionParametersType,
        string
    > _enumToString = new() { { OpenAiFunctionParametersType.Object, "object" } };

    public override OpenAiFunctionParametersType Read(
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
        OpenAiFunctionParametersType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiFunctionParametersType ReadAsPropertyName(
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
        OpenAiFunctionParametersType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
