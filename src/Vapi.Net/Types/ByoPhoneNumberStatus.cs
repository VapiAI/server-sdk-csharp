using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ByoPhoneNumberStatusSerializer))]
public enum ByoPhoneNumberStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "activating")]
    Activating,

    [EnumMember(Value = "blocked")]
    Blocked,
}

internal class ByoPhoneNumberStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ByoPhoneNumberStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ByoPhoneNumberStatus
    > _stringToEnum = new()
    {
        { "active", ByoPhoneNumberStatus.Active },
        { "activating", ByoPhoneNumberStatus.Activating },
        { "blocked", ByoPhoneNumberStatus.Blocked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ByoPhoneNumberStatus,
        string
    > _enumToString = new()
    {
        { ByoPhoneNumberStatus.Active, "active" },
        { ByoPhoneNumberStatus.Activating, "activating" },
        { ByoPhoneNumberStatus.Blocked, "blocked" },
    };

    public override ByoPhoneNumberStatus Read(
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
        ByoPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ByoPhoneNumberStatus ReadAsPropertyName(
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
        ByoPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
