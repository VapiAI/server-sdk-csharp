using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BackgroundSoundUrlValidationResultReasonSerializer))]
public enum BackgroundSoundUrlValidationResultReason
{
    [EnumMember(Value = "invalid-url")]
    InvalidUrl,

    [EnumMember(Value = "blocked-address")]
    BlockedAddress,

    [EnumMember(Value = "unreachable")]
    Unreachable,

    [EnumMember(Value = "timeout")]
    Timeout,

    [EnumMember(Value = "too-many-redirects")]
    TooManyRedirects,

    [EnumMember(Value = "http-error")]
    HttpError,

    [EnumMember(Value = "not-audio")]
    NotAudio,
}

internal class BackgroundSoundUrlValidationResultReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BackgroundSoundUrlValidationResultReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BackgroundSoundUrlValidationResultReason
    > _stringToEnum = new()
    {
        { "invalid-url", BackgroundSoundUrlValidationResultReason.InvalidUrl },
        { "blocked-address", BackgroundSoundUrlValidationResultReason.BlockedAddress },
        { "unreachable", BackgroundSoundUrlValidationResultReason.Unreachable },
        { "timeout", BackgroundSoundUrlValidationResultReason.Timeout },
        { "too-many-redirects", BackgroundSoundUrlValidationResultReason.TooManyRedirects },
        { "http-error", BackgroundSoundUrlValidationResultReason.HttpError },
        { "not-audio", BackgroundSoundUrlValidationResultReason.NotAudio },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BackgroundSoundUrlValidationResultReason,
        string
    > _enumToString = new()
    {
        { BackgroundSoundUrlValidationResultReason.InvalidUrl, "invalid-url" },
        { BackgroundSoundUrlValidationResultReason.BlockedAddress, "blocked-address" },
        { BackgroundSoundUrlValidationResultReason.Unreachable, "unreachable" },
        { BackgroundSoundUrlValidationResultReason.Timeout, "timeout" },
        { BackgroundSoundUrlValidationResultReason.TooManyRedirects, "too-many-redirects" },
        { BackgroundSoundUrlValidationResultReason.HttpError, "http-error" },
        { BackgroundSoundUrlValidationResultReason.NotAudio, "not-audio" },
    };

    public override BackgroundSoundUrlValidationResultReason Read(
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
        BackgroundSoundUrlValidationResultReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BackgroundSoundUrlValidationResultReason ReadAsPropertyName(
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
        BackgroundSoundUrlValidationResultReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
