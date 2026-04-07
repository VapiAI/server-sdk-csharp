using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureCredentialServiceSerializer))]
public enum AzureCredentialService
{
    [EnumMember(Value = "speech")]
    Speech,

    [EnumMember(Value = "blob_storage")]
    BlobStorage,
}

internal class AzureCredentialServiceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureCredentialService>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureCredentialService
    > _stringToEnum = new()
    {
        { "speech", AzureCredentialService.Speech },
        { "blob_storage", AzureCredentialService.BlobStorage },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureCredentialService,
        string
    > _enumToString = new()
    {
        { AzureCredentialService.Speech, "speech" },
        { AzureCredentialService.BlobStorage, "blob_storage" },
    };

    public override AzureCredentialService Read(
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
        AzureCredentialService value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureCredentialService ReadAsPropertyName(
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
        AzureCredentialService value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
