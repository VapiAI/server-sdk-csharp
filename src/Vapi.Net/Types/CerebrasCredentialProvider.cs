using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CerebrasCredentialProviderSerializer))]
public enum CerebrasCredentialProvider
{
    [EnumMember(Value = "cerebras")]
    Cerebras,
}

internal class CerebrasCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CerebrasCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CerebrasCredentialProvider
    > _stringToEnum = new() { { "cerebras", CerebrasCredentialProvider.Cerebras } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CerebrasCredentialProvider,
        string
    > _enumToString = new() { { CerebrasCredentialProvider.Cerebras, "cerebras" } };

    public override CerebrasCredentialProvider Read(
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
        CerebrasCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CerebrasCredentialProvider ReadAsPropertyName(
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
        CerebrasCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
