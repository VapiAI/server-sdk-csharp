using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateSipRequestToolDtoVerbSerializer))]
public enum UpdateSipRequestToolDtoVerb
{
    [EnumMember(Value = "INFO")]
    Info,

    [EnumMember(Value = "MESSAGE")]
    Message,

    [EnumMember(Value = "NOTIFY")]
    Notify,
}

internal class UpdateSipRequestToolDtoVerbSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateSipRequestToolDtoVerb>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateSipRequestToolDtoVerb
    > _stringToEnum = new()
    {
        { "INFO", UpdateSipRequestToolDtoVerb.Info },
        { "MESSAGE", UpdateSipRequestToolDtoVerb.Message },
        { "NOTIFY", UpdateSipRequestToolDtoVerb.Notify },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateSipRequestToolDtoVerb,
        string
    > _enumToString = new()
    {
        { UpdateSipRequestToolDtoVerb.Info, "INFO" },
        { UpdateSipRequestToolDtoVerb.Message, "MESSAGE" },
        { UpdateSipRequestToolDtoVerb.Notify, "NOTIFY" },
    };

    public override UpdateSipRequestToolDtoVerb Read(
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
        UpdateSipRequestToolDtoVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateSipRequestToolDtoVerb ReadAsPropertyName(
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
        UpdateSipRequestToolDtoVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
