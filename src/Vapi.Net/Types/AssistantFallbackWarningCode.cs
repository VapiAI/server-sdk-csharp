using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantFallbackWarningCodeSerializer))]
public enum AssistantFallbackWarningCode
{
    [EnumMember(Value = "fallback-voices-empty")]
    FallbackVoicesEmpty,

    [EnumMember(Value = "fallback-voice-same-provider")]
    FallbackVoiceSameProvider,

    [EnumMember(Value = "fallback-voice-language-unsupported")]
    FallbackVoiceLanguageUnsupported,

    [EnumMember(Value = "fallback-voice-invalid")]
    FallbackVoiceInvalid,

    [EnumMember(Value = "fallback-transcribers-empty")]
    FallbackTranscribersEmpty,

    [EnumMember(Value = "fallback-transcriber-same-provider")]
    FallbackTranscriberSameProvider,

    [EnumMember(Value = "fallback-transcriber-language-unsupported")]
    FallbackTranscriberLanguageUnsupported,
}

internal class AssistantFallbackWarningCodeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantFallbackWarningCode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantFallbackWarningCode
    > _stringToEnum = new()
    {
        { "fallback-voices-empty", AssistantFallbackWarningCode.FallbackVoicesEmpty },
        { "fallback-voice-same-provider", AssistantFallbackWarningCode.FallbackVoiceSameProvider },
        {
            "fallback-voice-language-unsupported",
            AssistantFallbackWarningCode.FallbackVoiceLanguageUnsupported
        },
        { "fallback-voice-invalid", AssistantFallbackWarningCode.FallbackVoiceInvalid },
        { "fallback-transcribers-empty", AssistantFallbackWarningCode.FallbackTranscribersEmpty },
        {
            "fallback-transcriber-same-provider",
            AssistantFallbackWarningCode.FallbackTranscriberSameProvider
        },
        {
            "fallback-transcriber-language-unsupported",
            AssistantFallbackWarningCode.FallbackTranscriberLanguageUnsupported
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantFallbackWarningCode,
        string
    > _enumToString = new()
    {
        { AssistantFallbackWarningCode.FallbackVoicesEmpty, "fallback-voices-empty" },
        { AssistantFallbackWarningCode.FallbackVoiceSameProvider, "fallback-voice-same-provider" },
        {
            AssistantFallbackWarningCode.FallbackVoiceLanguageUnsupported,
            "fallback-voice-language-unsupported"
        },
        { AssistantFallbackWarningCode.FallbackVoiceInvalid, "fallback-voice-invalid" },
        { AssistantFallbackWarningCode.FallbackTranscribersEmpty, "fallback-transcribers-empty" },
        {
            AssistantFallbackWarningCode.FallbackTranscriberSameProvider,
            "fallback-transcriber-same-provider"
        },
        {
            AssistantFallbackWarningCode.FallbackTranscriberLanguageUnsupported,
            "fallback-transcriber-language-unsupported"
        },
    };

    public override AssistantFallbackWarningCode Read(
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
        AssistantFallbackWarningCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantFallbackWarningCode ReadAsPropertyName(
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
        AssistantFallbackWarningCode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
