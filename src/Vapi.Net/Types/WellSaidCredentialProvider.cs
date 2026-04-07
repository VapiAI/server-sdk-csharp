using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WellSaidCredentialProviderSerializer))]
public enum WellSaidCredentialProvider
{
    [EnumMember(Value = "wellsaid")]
    Wellsaid,
}

internal class WellSaidCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WellSaidCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WellSaidCredentialProvider
    > _stringToEnum = new() { { "wellsaid", WellSaidCredentialProvider.Wellsaid } };

    private static readonly global::System.Collections.Generic.Dictionary<
        WellSaidCredentialProvider,
        string
    > _enumToString = new() { { WellSaidCredentialProvider.Wellsaid, "wellsaid" } };

    public override WellSaidCredentialProvider Read(
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
        WellSaidCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WellSaidCredentialProvider ReadAsPropertyName(
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
        WellSaidCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
