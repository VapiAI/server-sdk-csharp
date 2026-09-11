using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateWellSaidCredentialDtoProviderSerializer))]
public enum UpdateWellSaidCredentialDtoProvider
{
    [EnumMember(Value = "wellsaid")]
    Wellsaid,
}

internal class UpdateWellSaidCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateWellSaidCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateWellSaidCredentialDtoProvider
    > _stringToEnum = new() { { "wellsaid", UpdateWellSaidCredentialDtoProvider.Wellsaid } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateWellSaidCredentialDtoProvider,
        string
    > _enumToString = new() { { UpdateWellSaidCredentialDtoProvider.Wellsaid, "wellsaid" } };

    public override UpdateWellSaidCredentialDtoProvider Read(
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
        UpdateWellSaidCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateWellSaidCredentialDtoProvider ReadAsPropertyName(
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
        UpdateWellSaidCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
