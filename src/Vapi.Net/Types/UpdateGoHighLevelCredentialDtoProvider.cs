using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateGoHighLevelCredentialDtoProviderSerializer))]
public enum UpdateGoHighLevelCredentialDtoProvider
{
    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,
}

internal class UpdateGoHighLevelCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateGoHighLevelCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateGoHighLevelCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "gohighlevel", UpdateGoHighLevelCredentialDtoProvider.Gohighlevel },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateGoHighLevelCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateGoHighLevelCredentialDtoProvider.Gohighlevel, "gohighlevel" },
    };

    public override UpdateGoHighLevelCredentialDtoProvider Read(
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
        UpdateGoHighLevelCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateGoHighLevelCredentialDtoProvider ReadAsPropertyName(
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
        UpdateGoHighLevelCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
