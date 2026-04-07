using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PublicKeyEncryptionPlanAlgorithmSerializer))]
public enum PublicKeyEncryptionPlanAlgorithm
{
    [EnumMember(Value = "RSA-OAEP-256")]
    RsaOaep256,
}

internal class PublicKeyEncryptionPlanAlgorithmSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PublicKeyEncryptionPlanAlgorithm>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PublicKeyEncryptionPlanAlgorithm
    > _stringToEnum = new() { { "RSA-OAEP-256", PublicKeyEncryptionPlanAlgorithm.RsaOaep256 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        PublicKeyEncryptionPlanAlgorithm,
        string
    > _enumToString = new() { { PublicKeyEncryptionPlanAlgorithm.RsaOaep256, "RSA-OAEP-256" } };

    public override PublicKeyEncryptionPlanAlgorithm Read(
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
        PublicKeyEncryptionPlanAlgorithm value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PublicKeyEncryptionPlanAlgorithm ReadAsPropertyName(
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
        PublicKeyEncryptionPlanAlgorithm value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
