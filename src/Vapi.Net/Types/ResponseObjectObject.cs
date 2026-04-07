using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseObjectObjectSerializer))]
public enum ResponseObjectObject
{
    [EnumMember(Value = "response")]
    Response,
}

internal class ResponseObjectObjectSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseObjectObject>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseObjectObject
    > _stringToEnum = new() { { "response", ResponseObjectObject.Response } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseObjectObject,
        string
    > _enumToString = new() { { ResponseObjectObject.Response, "response" } };

    public override ResponseObjectObject Read(
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
        ResponseObjectObject value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseObjectObject ReadAsPropertyName(
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
        ResponseObjectObject value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
