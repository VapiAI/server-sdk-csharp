using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PlayHtCredentialProviderSerializer))]
public enum PlayHtCredentialProvider
{
    [EnumMember(Value = "playht")]
    Playht,
}

internal class PlayHtCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PlayHtCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PlayHtCredentialProvider
    > _stringToEnum = new() { { "playht", PlayHtCredentialProvider.Playht } };

    private static readonly global::System.Collections.Generic.Dictionary<
        PlayHtCredentialProvider,
        string
    > _enumToString = new() { { PlayHtCredentialProvider.Playht, "playht" } };

    public override PlayHtCredentialProvider Read(
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
        PlayHtCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PlayHtCredentialProvider ReadAsPropertyName(
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
        PlayHtCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
