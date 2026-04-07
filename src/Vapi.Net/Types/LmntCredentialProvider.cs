using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LmntCredentialProviderSerializer))]
public enum LmntCredentialProvider
{
    [EnumMember(Value = "lmnt")]
    Lmnt,
}

internal class LmntCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LmntCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LmntCredentialProvider
    > _stringToEnum = new() { { "lmnt", LmntCredentialProvider.Lmnt } };

    private static readonly global::System.Collections.Generic.Dictionary<
        LmntCredentialProvider,
        string
    > _enumToString = new() { { LmntCredentialProvider.Lmnt, "lmnt" } };

    public override LmntCredentialProvider Read(
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
        LmntCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LmntCredentialProvider ReadAsPropertyName(
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
        LmntCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
