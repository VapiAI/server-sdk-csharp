using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageLanguageChangeDetectedTypeSerializer))]
public enum ServerMessageLanguageChangeDetectedType
{
    [EnumMember(Value = "language-change-detected")]
    LanguageChangeDetected,
}

internal class ServerMessageLanguageChangeDetectedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageLanguageChangeDetectedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageLanguageChangeDetectedType
    > _stringToEnum = new()
    {
        {
            "language-change-detected",
            ServerMessageLanguageChangeDetectedType.LanguageChangeDetected
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageLanguageChangeDetectedType,
        string
    > _enumToString = new()
    {
        {
            ServerMessageLanguageChangeDetectedType.LanguageChangeDetected,
            "language-change-detected"
        },
    };

    public override ServerMessageLanguageChangeDetectedType Read(
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
        ServerMessageLanguageChangeDetectedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageLanguageChangeDetectedType ReadAsPropertyName(
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
        ServerMessageLanguageChangeDetectedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
