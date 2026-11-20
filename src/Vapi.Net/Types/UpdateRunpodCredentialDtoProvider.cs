using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateRunpodCredentialDtoProviderSerializer))]
public enum UpdateRunpodCredentialDtoProvider
{
    [EnumMember(Value = "runpod")]
    Runpod,
}

internal class UpdateRunpodCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateRunpodCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateRunpodCredentialDtoProvider
    > _stringToEnum = new() { { "runpod", UpdateRunpodCredentialDtoProvider.Runpod } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateRunpodCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateRunpodCredentialDtoProvider.Runpod, "runpod" } };

    public override UpdateRunpodCredentialDtoProvider Read(
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
        UpdateRunpodCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateRunpodCredentialDtoProvider ReadAsPropertyName(
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
        UpdateRunpodCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
