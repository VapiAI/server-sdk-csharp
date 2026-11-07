using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateWebCallDtoVideoRecordingStartModeSerializer))]
public enum CreateWebCallDtoVideoRecordingStartMode
{
    [EnumMember(Value = "client")]
    Client,

    [EnumMember(Value = "server")]
    Server,
}

internal class CreateWebCallDtoVideoRecordingStartModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateWebCallDtoVideoRecordingStartMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateWebCallDtoVideoRecordingStartMode
    > _stringToEnum = new()
    {
        { "client", CreateWebCallDtoVideoRecordingStartMode.Client },
        { "server", CreateWebCallDtoVideoRecordingStartMode.Server },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateWebCallDtoVideoRecordingStartMode,
        string
    > _enumToString = new()
    {
        { CreateWebCallDtoVideoRecordingStartMode.Client, "client" },
        { CreateWebCallDtoVideoRecordingStartMode.Server, "server" },
    };

    public override CreateWebCallDtoVideoRecordingStartMode Read(
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
        CreateWebCallDtoVideoRecordingStartMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateWebCallDtoVideoRecordingStartMode ReadAsPropertyName(
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
        CreateWebCallDtoVideoRecordingStartMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
