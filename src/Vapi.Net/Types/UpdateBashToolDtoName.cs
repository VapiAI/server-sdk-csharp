using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateBashToolDtoNameSerializer))]
public enum UpdateBashToolDtoName
{
    [EnumMember(Value = "bash")]
    Bash,
}

internal class UpdateBashToolDtoNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateBashToolDtoName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateBashToolDtoName
    > _stringToEnum = new() { { "bash", UpdateBashToolDtoName.Bash } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateBashToolDtoName,
        string
    > _enumToString = new() { { UpdateBashToolDtoName.Bash, "bash" } };

    public override UpdateBashToolDtoName Read(
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
        UpdateBashToolDtoName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateBashToolDtoName ReadAsPropertyName(
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
        UpdateBashToolDtoName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
