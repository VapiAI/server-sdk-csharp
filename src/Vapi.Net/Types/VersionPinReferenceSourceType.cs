using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VersionPinReferenceSourceTypeSerializer))]
public enum VersionPinReferenceSourceType
{
    [EnumMember(Value = "assistant_version")]
    AssistantVersion,

    [EnumMember(Value = "squad")]
    Squad,

    [EnumMember(Value = "tool_version")]
    ToolVersion,
}

internal class VersionPinReferenceSourceTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VersionPinReferenceSourceType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VersionPinReferenceSourceType
    > _stringToEnum = new()
    {
        { "assistant_version", VersionPinReferenceSourceType.AssistantVersion },
        { "squad", VersionPinReferenceSourceType.Squad },
        { "tool_version", VersionPinReferenceSourceType.ToolVersion },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VersionPinReferenceSourceType,
        string
    > _enumToString = new()
    {
        { VersionPinReferenceSourceType.AssistantVersion, "assistant_version" },
        { VersionPinReferenceSourceType.Squad, "squad" },
        { VersionPinReferenceSourceType.ToolVersion, "tool_version" },
    };

    public override VersionPinReferenceSourceType Read(
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
        VersionPinReferenceSourceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VersionPinReferenceSourceType ReadAsPropertyName(
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
        VersionPinReferenceSourceType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
