using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateCodeToolDtoTypeSerializer))]
public enum UpdateCodeToolDtoType
{
    [EnumMember(Value = "code")]
    Code,
}

internal class UpdateCodeToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateCodeToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateCodeToolDtoType
    > _stringToEnum = new() { { "code", UpdateCodeToolDtoType.Code } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateCodeToolDtoType,
        string
    > _enumToString = new() { { UpdateCodeToolDtoType.Code, "code" } };

    public override UpdateCodeToolDtoType Read(
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
        UpdateCodeToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateCodeToolDtoType ReadAsPropertyName(
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
        UpdateCodeToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
