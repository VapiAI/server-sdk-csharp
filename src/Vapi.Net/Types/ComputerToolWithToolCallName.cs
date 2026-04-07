using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ComputerToolWithToolCallNameSerializer))]
public enum ComputerToolWithToolCallName
{
    [EnumMember(Value = "computer")]
    Computer,
}

internal class ComputerToolWithToolCallNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ComputerToolWithToolCallName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ComputerToolWithToolCallName
    > _stringToEnum = new() { { "computer", ComputerToolWithToolCallName.Computer } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ComputerToolWithToolCallName,
        string
    > _enumToString = new() { { ComputerToolWithToolCallName.Computer, "computer" } };

    public override ComputerToolWithToolCallName Read(
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
        ComputerToolWithToolCallName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ComputerToolWithToolCallName ReadAsPropertyName(
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
        ComputerToolWithToolCallName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
