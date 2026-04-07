using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiPhoneNumberStatusSerializer))]
public enum VapiPhoneNumberStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "activating")]
    Activating,

    [EnumMember(Value = "blocked")]
    Blocked,
}

internal class VapiPhoneNumberStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiPhoneNumberStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiPhoneNumberStatus
    > _stringToEnum = new()
    {
        { "active", VapiPhoneNumberStatus.Active },
        { "activating", VapiPhoneNumberStatus.Activating },
        { "blocked", VapiPhoneNumberStatus.Blocked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiPhoneNumberStatus,
        string
    > _enumToString = new()
    {
        { VapiPhoneNumberStatus.Active, "active" },
        { VapiPhoneNumberStatus.Activating, "activating" },
        { VapiPhoneNumberStatus.Blocked, "blocked" },
    };

    public override VapiPhoneNumberStatus Read(
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
        VapiPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiPhoneNumberStatus ReadAsPropertyName(
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
        VapiPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
