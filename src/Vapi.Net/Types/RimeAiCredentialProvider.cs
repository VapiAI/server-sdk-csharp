using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RimeAiCredentialProviderSerializer))]
public enum RimeAiCredentialProvider
{
    [EnumMember(Value = "rime-ai")]
    RimeAi,
}

internal class RimeAiCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RimeAiCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RimeAiCredentialProvider
    > _stringToEnum = new() { { "rime-ai", RimeAiCredentialProvider.RimeAi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        RimeAiCredentialProvider,
        string
    > _enumToString = new() { { RimeAiCredentialProvider.RimeAi, "rime-ai" } };

    public override RimeAiCredentialProvider Read(
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
        RimeAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RimeAiCredentialProvider ReadAsPropertyName(
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
        RimeAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
