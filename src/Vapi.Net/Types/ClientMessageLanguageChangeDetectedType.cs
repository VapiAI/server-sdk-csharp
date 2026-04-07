using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageLanguageChangeDetectedTypeSerializer))]
public enum ClientMessageLanguageChangeDetectedType
{
    [EnumMember(Value = "language-change-detected")]
    LanguageChangeDetected,
}

internal class ClientMessageLanguageChangeDetectedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageLanguageChangeDetectedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageLanguageChangeDetectedType
    > _stringToEnum = new()
    {
        {
            "language-change-detected",
            ClientMessageLanguageChangeDetectedType.LanguageChangeDetected
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageLanguageChangeDetectedType,
        string
    > _enumToString = new()
    {
        {
            ClientMessageLanguageChangeDetectedType.LanguageChangeDetected,
            "language-change-detected"
        },
    };

    public override ClientMessageLanguageChangeDetectedType Read(
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
        ClientMessageLanguageChangeDetectedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageLanguageChangeDetectedType ReadAsPropertyName(
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
        ClientMessageLanguageChangeDetectedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
