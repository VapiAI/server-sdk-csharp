using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAnyscaleCredentialDtoProviderSerializer))]
public enum UpdateAnyscaleCredentialDtoProvider
{
    [EnumMember(Value = "anyscale")]
    Anyscale,
}

internal class UpdateAnyscaleCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAnyscaleCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAnyscaleCredentialDtoProvider
    > _stringToEnum = new() { { "anyscale", UpdateAnyscaleCredentialDtoProvider.Anyscale } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAnyscaleCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateAnyscaleCredentialDtoProvider.Anyscale, "anyscale" } };

    public override UpdateAnyscaleCredentialDtoProvider Read(
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
        UpdateAnyscaleCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAnyscaleCredentialDtoProvider ReadAsPropertyName(
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
        UpdateAnyscaleCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
