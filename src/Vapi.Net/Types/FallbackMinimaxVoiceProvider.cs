using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMinimaxVoiceProviderSerializer))]
public enum FallbackMinimaxVoiceProvider
{
    [EnumMember(Value = "minimax")]
    Minimax,
}

internal class FallbackMinimaxVoiceProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMinimaxVoiceProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMinimaxVoiceProvider
    > _stringToEnum = new() { { "minimax", FallbackMinimaxVoiceProvider.Minimax } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMinimaxVoiceProvider,
        string
    > _enumToString = new() { { FallbackMinimaxVoiceProvider.Minimax, "minimax" } };

    public override FallbackMinimaxVoiceProvider Read(
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
        FallbackMinimaxVoiceProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMinimaxVoiceProvider ReadAsPropertyName(
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
        FallbackMinimaxVoiceProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
