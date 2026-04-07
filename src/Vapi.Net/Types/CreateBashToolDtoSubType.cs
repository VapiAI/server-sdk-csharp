using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateBashToolDtoSubTypeSerializer))]
public enum CreateBashToolDtoSubType
{
    [EnumMember(Value = "bash_20241022")]
    Bash20241022,
}

internal class CreateBashToolDtoSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateBashToolDtoSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateBashToolDtoSubType
    > _stringToEnum = new() { { "bash_20241022", CreateBashToolDtoSubType.Bash20241022 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateBashToolDtoSubType,
        string
    > _enumToString = new() { { CreateBashToolDtoSubType.Bash20241022, "bash_20241022" } };

    public override CreateBashToolDtoSubType Read(
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
        CreateBashToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateBashToolDtoSubType ReadAsPropertyName(
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
        CreateBashToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
