using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BashToolWithToolCallNameSerializer))]
public enum BashToolWithToolCallName
{
    [EnumMember(Value = "bash")]
    Bash,
}

internal class BashToolWithToolCallNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BashToolWithToolCallName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BashToolWithToolCallName
    > _stringToEnum = new() { { "bash", BashToolWithToolCallName.Bash } };

    private static readonly global::System.Collections.Generic.Dictionary<
        BashToolWithToolCallName,
        string
    > _enumToString = new() { { BashToolWithToolCallName.Bash, "bash" } };

    public override BashToolWithToolCallName Read(
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
        BashToolWithToolCallName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BashToolWithToolCallName ReadAsPropertyName(
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
        BashToolWithToolCallName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
