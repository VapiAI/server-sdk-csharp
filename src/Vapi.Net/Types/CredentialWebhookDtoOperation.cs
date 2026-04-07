using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CredentialWebhookDtoOperationSerializer))]
public enum CredentialWebhookDtoOperation
{
    [EnumMember(Value = "creation")]
    Creation,

    [EnumMember(Value = "override")]
    Override,

    [EnumMember(Value = "refresh")]
    Refresh,
}

internal class CredentialWebhookDtoOperationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CredentialWebhookDtoOperation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CredentialWebhookDtoOperation
    > _stringToEnum = new()
    {
        { "creation", CredentialWebhookDtoOperation.Creation },
        { "override", CredentialWebhookDtoOperation.Override },
        { "refresh", CredentialWebhookDtoOperation.Refresh },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CredentialWebhookDtoOperation,
        string
    > _enumToString = new()
    {
        { CredentialWebhookDtoOperation.Creation, "creation" },
        { CredentialWebhookDtoOperation.Override, "override" },
        { CredentialWebhookDtoOperation.Refresh, "refresh" },
    };

    public override CredentialWebhookDtoOperation Read(
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
        CredentialWebhookDtoOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CredentialWebhookDtoOperation ReadAsPropertyName(
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
        CredentialWebhookDtoOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
