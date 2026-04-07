using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssemblyAiCredentialProviderSerializer))]
public enum AssemblyAiCredentialProvider
{
    [EnumMember(Value = "assembly-ai")]
    AssemblyAi,
}

internal class AssemblyAiCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssemblyAiCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssemblyAiCredentialProvider
    > _stringToEnum = new() { { "assembly-ai", AssemblyAiCredentialProvider.AssemblyAi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssemblyAiCredentialProvider,
        string
    > _enumToString = new() { { AssemblyAiCredentialProvider.AssemblyAi, "assembly-ai" } };

    public override AssemblyAiCredentialProvider Read(
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
        AssemblyAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssemblyAiCredentialProvider ReadAsPropertyName(
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
        AssemblyAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
