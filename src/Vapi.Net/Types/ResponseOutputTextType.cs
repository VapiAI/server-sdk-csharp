using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseOutputTextTypeSerializer))]
public enum ResponseOutputTextType
{
    [EnumMember(Value = "output_text")]
    OutputText,
}

internal class ResponseOutputTextTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseOutputTextType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseOutputTextType
    > _stringToEnum = new() { { "output_text", ResponseOutputTextType.OutputText } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseOutputTextType,
        string
    > _enumToString = new() { { ResponseOutputTextType.OutputText, "output_text" } };

    public override ResponseOutputTextType Read(
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
        ResponseOutputTextType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseOutputTextType ReadAsPropertyName(
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
        ResponseOutputTextType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
