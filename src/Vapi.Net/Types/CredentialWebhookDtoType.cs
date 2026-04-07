using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CredentialWebhookDtoTypeSerializer))]
public enum CredentialWebhookDtoType
{
    [EnumMember(Value = "auth")]
    Auth,

    [EnumMember(Value = "sync")]
    Sync,

    [EnumMember(Value = "forward")]
    Forward,
}

internal class CredentialWebhookDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CredentialWebhookDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CredentialWebhookDtoType
    > _stringToEnum = new()
    {
        { "auth", CredentialWebhookDtoType.Auth },
        { "sync", CredentialWebhookDtoType.Sync },
        { "forward", CredentialWebhookDtoType.Forward },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CredentialWebhookDtoType,
        string
    > _enumToString = new()
    {
        { CredentialWebhookDtoType.Auth, "auth" },
        { CredentialWebhookDtoType.Sync, "sync" },
        { CredentialWebhookDtoType.Forward, "forward" },
    };

    public override CredentialWebhookDtoType Read(
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
        CredentialWebhookDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CredentialWebhookDtoType ReadAsPropertyName(
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
        CredentialWebhookDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
