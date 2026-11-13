using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CustomerSpeechTimeoutOptionsTriggerResetModeSerializer))]
public enum CustomerSpeechTimeoutOptionsTriggerResetMode
{
    [EnumMember(Value = "onUserSpeech")]
    OnUserSpeech,

    [EnumMember(Value = "never")]
    Never,
}

internal class CustomerSpeechTimeoutOptionsTriggerResetModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CustomerSpeechTimeoutOptionsTriggerResetMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CustomerSpeechTimeoutOptionsTriggerResetMode
    > _stringToEnum = new()
    {
        { "onUserSpeech", CustomerSpeechTimeoutOptionsTriggerResetMode.OnUserSpeech },
        { "never", CustomerSpeechTimeoutOptionsTriggerResetMode.Never },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CustomerSpeechTimeoutOptionsTriggerResetMode,
        string
    > _enumToString = new()
    {
        { CustomerSpeechTimeoutOptionsTriggerResetMode.OnUserSpeech, "onUserSpeech" },
        { CustomerSpeechTimeoutOptionsTriggerResetMode.Never, "never" },
    };

    public override CustomerSpeechTimeoutOptionsTriggerResetMode Read(
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
        CustomerSpeechTimeoutOptionsTriggerResetMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CustomerSpeechTimeoutOptionsTriggerResetMode ReadAsPropertyName(
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
        CustomerSpeechTimeoutOptionsTriggerResetMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
