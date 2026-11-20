using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProviderSerializer))]
public enum UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider
{
    [EnumMember(Value = "google.sheets.oauth2-authorization")]
    GoogleSheetsOauth2Authorization,
}

internal class UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider
    > _stringToEnum = new()
    {
        {
            "google.sheets.oauth2-authorization",
            UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider.GoogleSheetsOauth2Authorization
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        {
            UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider.GoogleSheetsOauth2Authorization,
            "google.sheets.oauth2-authorization"
        },
    };

    public override UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider Read(
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
        UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider ReadAsPropertyName(
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
        UpdateGoogleSheetsOAuth2AuthorizationCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
