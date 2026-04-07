using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateEvalRunDtoTypeSerializer))]
public enum CreateEvalRunDtoType
{
    [EnumMember(Value = "eval")]
    Eval,
}

internal class CreateEvalRunDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateEvalRunDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateEvalRunDtoType
    > _stringToEnum = new() { { "eval", CreateEvalRunDtoType.Eval } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateEvalRunDtoType,
        string
    > _enumToString = new() { { CreateEvalRunDtoType.Eval, "eval" } };

    public override CreateEvalRunDtoType Read(
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
        CreateEvalRunDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateEvalRunDtoType ReadAsPropertyName(
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
        CreateEvalRunDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
