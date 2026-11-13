using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(S3CompatibleStorageCredentialProviderSerializer))]
public enum S3CompatibleStorageCredentialProvider
{
    [EnumMember(Value = "s3-compatible")]
    S3Compatible,
}

internal class S3CompatibleStorageCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<S3CompatibleStorageCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        S3CompatibleStorageCredentialProvider
    > _stringToEnum = new()
    {
        { "s3-compatible", S3CompatibleStorageCredentialProvider.S3Compatible },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        S3CompatibleStorageCredentialProvider,
        string
    > _enumToString = new()
    {
        { S3CompatibleStorageCredentialProvider.S3Compatible, "s3-compatible" },
    };

    public override S3CompatibleStorageCredentialProvider Read(
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
        S3CompatibleStorageCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override S3CompatibleStorageCredentialProvider ReadAsPropertyName(
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
        S3CompatibleStorageCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
