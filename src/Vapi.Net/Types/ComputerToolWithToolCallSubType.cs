using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ComputerToolWithToolCallSubTypeSerializer))]
public enum ComputerToolWithToolCallSubType
{
    [EnumMember(Value = "computer_20241022")]
    Computer20241022,
}

internal class ComputerToolWithToolCallSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ComputerToolWithToolCallSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ComputerToolWithToolCallSubType
    > _stringToEnum = new()
    {
        { "computer_20241022", ComputerToolWithToolCallSubType.Computer20241022 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ComputerToolWithToolCallSubType,
        string
    > _enumToString = new()
    {
        { ComputerToolWithToolCallSubType.Computer20241022, "computer_20241022" },
    };

    public override ComputerToolWithToolCallSubType Read(
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
        ComputerToolWithToolCallSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ComputerToolWithToolCallSubType ReadAsPropertyName(
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
        ComputerToolWithToolCallSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
