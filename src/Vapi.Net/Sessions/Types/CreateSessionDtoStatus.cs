using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateSessionDtoStatusSerializer))]
public enum CreateSessionDtoStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "completed")]
    Completed,
}

internal class CreateSessionDtoStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateSessionDtoStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateSessionDtoStatus
    > _stringToEnum = new()
    {
        { "active", CreateSessionDtoStatus.Active },
        { "completed", CreateSessionDtoStatus.Completed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateSessionDtoStatus,
        string
    > _enumToString = new()
    {
        { CreateSessionDtoStatus.Active, "active" },
        { CreateSessionDtoStatus.Completed, "completed" },
    };

    public override CreateSessionDtoStatus Read(
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
        CreateSessionDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateSessionDtoStatus ReadAsPropertyName(
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
        CreateSessionDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
