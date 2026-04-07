using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateBashToolDtoSubTypeSerializer))]
public enum UpdateBashToolDtoSubType
{
    [EnumMember(Value = "bash_20241022")]
    Bash20241022,
}

internal class UpdateBashToolDtoSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateBashToolDtoSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateBashToolDtoSubType
    > _stringToEnum = new() { { "bash_20241022", UpdateBashToolDtoSubType.Bash20241022 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateBashToolDtoSubType,
        string
    > _enumToString = new() { { UpdateBashToolDtoSubType.Bash20241022, "bash_20241022" } };

    public override UpdateBashToolDtoSubType Read(
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
        UpdateBashToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateBashToolDtoSubType ReadAsPropertyName(
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
        UpdateBashToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
