using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BashToolWithToolCallSubTypeSerializer))]
public enum BashToolWithToolCallSubType
{
    [EnumMember(Value = "bash_20241022")]
    Bash20241022,
}

internal class BashToolWithToolCallSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BashToolWithToolCallSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BashToolWithToolCallSubType
    > _stringToEnum = new() { { "bash_20241022", BashToolWithToolCallSubType.Bash20241022 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        BashToolWithToolCallSubType,
        string
    > _enumToString = new() { { BashToolWithToolCallSubType.Bash20241022, "bash_20241022" } };

    public override BashToolWithToolCallSubType Read(
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
        BashToolWithToolCallSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BashToolWithToolCallSubType ReadAsPropertyName(
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
        BashToolWithToolCallSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
