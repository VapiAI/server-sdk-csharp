using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateCloudflareCredentialDtoProviderSerializer))]
public enum UpdateCloudflareCredentialDtoProvider
{
    [EnumMember(Value = "cloudflare")]
    Cloudflare,
}

internal class UpdateCloudflareCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateCloudflareCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateCloudflareCredentialDtoProvider
    > _stringToEnum = new() { { "cloudflare", UpdateCloudflareCredentialDtoProvider.Cloudflare } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateCloudflareCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateCloudflareCredentialDtoProvider.Cloudflare, "cloudflare" } };

    public override UpdateCloudflareCredentialDtoProvider Read(
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
        UpdateCloudflareCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateCloudflareCredentialDtoProvider ReadAsPropertyName(
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
        UpdateCloudflareCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
