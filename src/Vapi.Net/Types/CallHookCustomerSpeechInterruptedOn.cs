using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHookCustomerSpeechInterruptedOnSerializer))]
public enum CallHookCustomerSpeechInterruptedOn
{
    [EnumMember(Value = "customer.speech.interrupted")]
    CustomerSpeechInterrupted,
}

internal class CallHookCustomerSpeechInterruptedOnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHookCustomerSpeechInterruptedOn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHookCustomerSpeechInterruptedOn
    > _stringToEnum = new()
    {
        {
            "customer.speech.interrupted",
            CallHookCustomerSpeechInterruptedOn.CustomerSpeechInterrupted
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHookCustomerSpeechInterruptedOn,
        string
    > _enumToString = new()
    {
        {
            CallHookCustomerSpeechInterruptedOn.CustomerSpeechInterrupted,
            "customer.speech.interrupted"
        },
    };

    public override CallHookCustomerSpeechInterruptedOn Read(
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
        CallHookCustomerSpeechInterruptedOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHookCustomerSpeechInterruptedOn ReadAsPropertyName(
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
        CallHookCustomerSpeechInterruptedOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
