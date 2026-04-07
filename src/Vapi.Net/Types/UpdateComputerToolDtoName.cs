using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateComputerToolDtoNameSerializer))]
public enum UpdateComputerToolDtoName
{
    [EnumMember(Value = "computer")]
    Computer,
}

internal class UpdateComputerToolDtoNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateComputerToolDtoName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateComputerToolDtoName
    > _stringToEnum = new() { { "computer", UpdateComputerToolDtoName.Computer } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateComputerToolDtoName,
        string
    > _enumToString = new() { { UpdateComputerToolDtoName.Computer, "computer" } };

    public override UpdateComputerToolDtoName Read(
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
        UpdateComputerToolDtoName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateComputerToolDtoName ReadAsPropertyName(
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
        UpdateComputerToolDtoName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
