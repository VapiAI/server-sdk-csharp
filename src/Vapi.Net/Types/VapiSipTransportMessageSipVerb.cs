using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiSipTransportMessageSipVerbSerializer))]
public enum VapiSipTransportMessageSipVerb
{
    [EnumMember(Value = "INFO")]
    Info,

    [EnumMember(Value = "MESSAGE")]
    Message,

    [EnumMember(Value = "NOTIFY")]
    Notify,
}

internal class VapiSipTransportMessageSipVerbSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiSipTransportMessageSipVerb>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiSipTransportMessageSipVerb
    > _stringToEnum = new()
    {
        { "INFO", VapiSipTransportMessageSipVerb.Info },
        { "MESSAGE", VapiSipTransportMessageSipVerb.Message },
        { "NOTIFY", VapiSipTransportMessageSipVerb.Notify },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiSipTransportMessageSipVerb,
        string
    > _enumToString = new()
    {
        { VapiSipTransportMessageSipVerb.Info, "INFO" },
        { VapiSipTransportMessageSipVerb.Message, "MESSAGE" },
        { VapiSipTransportMessageSipVerb.Notify, "NOTIFY" },
    };

    public override VapiSipTransportMessageSipVerb Read(
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
        VapiSipTransportMessageSipVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiSipTransportMessageSipVerb ReadAsPropertyName(
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
        VapiSipTransportMessageSipVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
