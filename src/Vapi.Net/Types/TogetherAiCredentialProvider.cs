using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TogetherAiCredentialProviderSerializer))]
public enum TogetherAiCredentialProvider
{
    [EnumMember(Value = "together-ai")]
    TogetherAi,
}

internal class TogetherAiCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TogetherAiCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TogetherAiCredentialProvider
    > _stringToEnum = new() { { "together-ai", TogetherAiCredentialProvider.TogetherAi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TogetherAiCredentialProvider,
        string
    > _enumToString = new() { { TogetherAiCredentialProvider.TogetherAi, "together-ai" } };

    public override TogetherAiCredentialProvider Read(
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
        TogetherAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TogetherAiCredentialProvider ReadAsPropertyName(
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
        TogetherAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
