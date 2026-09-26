using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateToolDraftDtoVerbSerializer))]
public enum CreateToolDraftDtoVerb
{
    [EnumMember(Value = "INFO")]
    Info,

    [EnumMember(Value = "MESSAGE")]
    Message,

    [EnumMember(Value = "NOTIFY")]
    Notify,
}

internal class CreateToolDraftDtoVerbSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateToolDraftDtoVerb>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateToolDraftDtoVerb
    > _stringToEnum = new()
    {
        { "INFO", CreateToolDraftDtoVerb.Info },
        { "MESSAGE", CreateToolDraftDtoVerb.Message },
        { "NOTIFY", CreateToolDraftDtoVerb.Notify },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateToolDraftDtoVerb,
        string
    > _enumToString = new()
    {
        { CreateToolDraftDtoVerb.Info, "INFO" },
        { CreateToolDraftDtoVerb.Message, "MESSAGE" },
        { CreateToolDraftDtoVerb.Notify, "NOTIFY" },
    };

    public override CreateToolDraftDtoVerb Read(
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
        CreateToolDraftDtoVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateToolDraftDtoVerb ReadAsPropertyName(
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
        CreateToolDraftDtoVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
