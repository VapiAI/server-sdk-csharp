using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAzureCredentialDtoServiceSerializer))]
public enum UpdateAzureCredentialDtoService
{
    [EnumMember(Value = "speech")]
    Speech,

    [EnumMember(Value = "blob_storage")]
    BlobStorage,
}

internal class UpdateAzureCredentialDtoServiceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAzureCredentialDtoService>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAzureCredentialDtoService
    > _stringToEnum = new()
    {
        { "speech", UpdateAzureCredentialDtoService.Speech },
        { "blob_storage", UpdateAzureCredentialDtoService.BlobStorage },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAzureCredentialDtoService,
        string
    > _enumToString = new()
    {
        { UpdateAzureCredentialDtoService.Speech, "speech" },
        { UpdateAzureCredentialDtoService.BlobStorage, "blob_storage" },
    };

    public override UpdateAzureCredentialDtoService Read(
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
        UpdateAzureCredentialDtoService value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAzureCredentialDtoService ReadAsPropertyName(
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
        UpdateAzureCredentialDtoService value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
