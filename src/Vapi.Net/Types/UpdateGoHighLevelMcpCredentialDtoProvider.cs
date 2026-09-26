using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateGoHighLevelMcpCredentialDtoProviderSerializer))]
public enum UpdateGoHighLevelMcpCredentialDtoProvider
{
    [EnumMember(Value = "ghl.oauth2-authorization")]
    GhlOauth2Authorization,
}

internal class UpdateGoHighLevelMcpCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateGoHighLevelMcpCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateGoHighLevelMcpCredentialDtoProvider
    > _stringToEnum = new()
    {
        {
            "ghl.oauth2-authorization",
            UpdateGoHighLevelMcpCredentialDtoProvider.GhlOauth2Authorization
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateGoHighLevelMcpCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        {
            UpdateGoHighLevelMcpCredentialDtoProvider.GhlOauth2Authorization,
            "ghl.oauth2-authorization"
        },
    };

    public override UpdateGoHighLevelMcpCredentialDtoProvider Read(
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
        UpdateGoHighLevelMcpCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateGoHighLevelMcpCredentialDtoProvider ReadAsPropertyName(
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
        UpdateGoHighLevelMcpCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
