using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateStructuredOutputDtoTypeSerializer))]
public enum CreateStructuredOutputDtoType
{
    [EnumMember(Value = "ai")]
    Ai,

    [EnumMember(Value = "regex")]
    Regex,
}

internal class CreateStructuredOutputDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateStructuredOutputDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateStructuredOutputDtoType
    > _stringToEnum = new()
    {
        { "ai", CreateStructuredOutputDtoType.Ai },
        { "regex", CreateStructuredOutputDtoType.Regex },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateStructuredOutputDtoType,
        string
    > _enumToString = new()
    {
        { CreateStructuredOutputDtoType.Ai, "ai" },
        { CreateStructuredOutputDtoType.Regex, "regex" },
    };

    public override CreateStructuredOutputDtoType Read(
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
        CreateStructuredOutputDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateStructuredOutputDtoType ReadAsPropertyName(
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
        CreateStructuredOutputDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
