using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PhoneNumberCallEndingHookFilterOneOfItemSerializer))]
public enum PhoneNumberCallEndingHookFilterOneOfItem
{
    [EnumMember(Value = "assistant-request-failed")]
    AssistantRequestFailed,

    [EnumMember(Value = "assistant-request-returned-error")]
    AssistantRequestReturnedError,

    [EnumMember(Value = "assistant-request-returned-unspeakable-error")]
    AssistantRequestReturnedUnspeakableError,

    [EnumMember(Value = "assistant-request-returned-invalid-assistant")]
    AssistantRequestReturnedInvalidAssistant,

    [EnumMember(Value = "assistant-request-returned-no-assistant")]
    AssistantRequestReturnedNoAssistant,

    [EnumMember(Value = "assistant-request-returned-forwarding-phone-number")]
    AssistantRequestReturnedForwardingPhoneNumber,
}

internal class PhoneNumberCallEndingHookFilterOneOfItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PhoneNumberCallEndingHookFilterOneOfItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PhoneNumberCallEndingHookFilterOneOfItem
    > _stringToEnum = new()
    {
        {
            "assistant-request-failed",
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestFailed
        },
        {
            "assistant-request-returned-error",
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedError
        },
        {
            "assistant-request-returned-unspeakable-error",
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedUnspeakableError
        },
        {
            "assistant-request-returned-invalid-assistant",
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedInvalidAssistant
        },
        {
            "assistant-request-returned-no-assistant",
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedNoAssistant
        },
        {
            "assistant-request-returned-forwarding-phone-number",
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedForwardingPhoneNumber
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PhoneNumberCallEndingHookFilterOneOfItem,
        string
    > _enumToString = new()
    {
        {
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestFailed,
            "assistant-request-failed"
        },
        {
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedError,
            "assistant-request-returned-error"
        },
        {
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedUnspeakableError,
            "assistant-request-returned-unspeakable-error"
        },
        {
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedInvalidAssistant,
            "assistant-request-returned-invalid-assistant"
        },
        {
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedNoAssistant,
            "assistant-request-returned-no-assistant"
        },
        {
            PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedForwardingPhoneNumber,
            "assistant-request-returned-forwarding-phone-number"
        },
    };

    public override PhoneNumberCallEndingHookFilterOneOfItem Read(
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
        PhoneNumberCallEndingHookFilterOneOfItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PhoneNumberCallEndingHookFilterOneOfItem ReadAsPropertyName(
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
        PhoneNumberCallEndingHookFilterOneOfItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
