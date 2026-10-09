using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateS3CompatibleCredentialDtoProviderSerializer))]
public enum UpdateS3CompatibleCredentialDtoProvider
{
    [EnumMember(Value = "s3-compatible")]
    S3Compatible,
}

internal class UpdateS3CompatibleCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateS3CompatibleCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateS3CompatibleCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "s3-compatible", UpdateS3CompatibleCredentialDtoProvider.S3Compatible },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateS3CompatibleCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateS3CompatibleCredentialDtoProvider.S3Compatible, "s3-compatible" },
    };

    public override UpdateS3CompatibleCredentialDtoProvider Read(
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
        UpdateS3CompatibleCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateS3CompatibleCredentialDtoProvider ReadAsPropertyName(
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
        UpdateS3CompatibleCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
