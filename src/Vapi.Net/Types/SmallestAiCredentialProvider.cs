using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SmallestAiCredentialProviderSerializer))]
public enum SmallestAiCredentialProvider
{
    [EnumMember(Value = "smallest-ai")]
    SmallestAi,
}

internal class SmallestAiCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SmallestAiCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SmallestAiCredentialProvider
    > _stringToEnum = new() { { "smallest-ai", SmallestAiCredentialProvider.SmallestAi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SmallestAiCredentialProvider,
        string
    > _enumToString = new() { { SmallestAiCredentialProvider.SmallestAi, "smallest-ai" } };

    public override SmallestAiCredentialProvider Read(
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
        SmallestAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SmallestAiCredentialProvider ReadAsPropertyName(
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
        SmallestAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
