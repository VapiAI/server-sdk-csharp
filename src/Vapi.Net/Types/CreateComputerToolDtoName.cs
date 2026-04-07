using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateComputerToolDtoNameSerializer))]
public enum CreateComputerToolDtoName
{
    [EnumMember(Value = "computer")]
    Computer,
}

internal class CreateComputerToolDtoNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateComputerToolDtoName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateComputerToolDtoName
    > _stringToEnum = new() { { "computer", CreateComputerToolDtoName.Computer } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateComputerToolDtoName,
        string
    > _enumToString = new() { { CreateComputerToolDtoName.Computer, "computer" } };

    public override CreateComputerToolDtoName Read(
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
        CreateComputerToolDtoName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateComputerToolDtoName ReadAsPropertyName(
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
        CreateComputerToolDtoName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
