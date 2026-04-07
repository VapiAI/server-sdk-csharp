using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateSipRequestToolDtoVerbSerializer))]
public enum CreateSipRequestToolDtoVerb
{
    [EnumMember(Value = "INFO")]
    Info,

    [EnumMember(Value = "MESSAGE")]
    Message,

    [EnumMember(Value = "NOTIFY")]
    Notify,
}

internal class CreateSipRequestToolDtoVerbSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateSipRequestToolDtoVerb>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateSipRequestToolDtoVerb
    > _stringToEnum = new()
    {
        { "INFO", CreateSipRequestToolDtoVerb.Info },
        { "MESSAGE", CreateSipRequestToolDtoVerb.Message },
        { "NOTIFY", CreateSipRequestToolDtoVerb.Notify },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateSipRequestToolDtoVerb,
        string
    > _enumToString = new()
    {
        { CreateSipRequestToolDtoVerb.Info, "INFO" },
        { CreateSipRequestToolDtoVerb.Message, "MESSAGE" },
        { CreateSipRequestToolDtoVerb.Notify, "NOTIFY" },
    };

    public override CreateSipRequestToolDtoVerb Read(
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
        CreateSipRequestToolDtoVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateSipRequestToolDtoVerb ReadAsPropertyName(
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
        CreateSipRequestToolDtoVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
