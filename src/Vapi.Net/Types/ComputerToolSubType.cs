using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ComputerToolSubTypeSerializer))]
public enum ComputerToolSubType
{
    [EnumMember(Value = "computer_20241022")]
    Computer20241022,
}

internal class ComputerToolSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ComputerToolSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ComputerToolSubType
    > _stringToEnum = new() { { "computer_20241022", ComputerToolSubType.Computer20241022 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ComputerToolSubType,
        string
    > _enumToString = new() { { ComputerToolSubType.Computer20241022, "computer_20241022" } };

    public override ComputerToolSubType Read(
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
        ComputerToolSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ComputerToolSubType ReadAsPropertyName(
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
        ComputerToolSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
