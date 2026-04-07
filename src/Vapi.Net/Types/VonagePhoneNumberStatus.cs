using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VonagePhoneNumberStatusSerializer))]
public enum VonagePhoneNumberStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "activating")]
    Activating,

    [EnumMember(Value = "blocked")]
    Blocked,
}

internal class VonagePhoneNumberStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VonagePhoneNumberStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VonagePhoneNumberStatus
    > _stringToEnum = new()
    {
        { "active", VonagePhoneNumberStatus.Active },
        { "activating", VonagePhoneNumberStatus.Activating },
        { "blocked", VonagePhoneNumberStatus.Blocked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VonagePhoneNumberStatus,
        string
    > _enumToString = new()
    {
        { VonagePhoneNumberStatus.Active, "active" },
        { VonagePhoneNumberStatus.Activating, "activating" },
        { VonagePhoneNumberStatus.Blocked, "blocked" },
    };

    public override VonagePhoneNumberStatus Read(
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
        VonagePhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VonagePhoneNumberStatus ReadAsPropertyName(
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
        VonagePhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
