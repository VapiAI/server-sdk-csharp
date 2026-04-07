using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SecurityFilterPlanModeSerializer))]
public enum SecurityFilterPlanMode
{
    [EnumMember(Value = "sanitize")]
    Sanitize,

    [EnumMember(Value = "reject")]
    Reject,

    [EnumMember(Value = "replace")]
    Replace,
}

internal class SecurityFilterPlanModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SecurityFilterPlanMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SecurityFilterPlanMode
    > _stringToEnum = new()
    {
        { "sanitize", SecurityFilterPlanMode.Sanitize },
        { "reject", SecurityFilterPlanMode.Reject },
        { "replace", SecurityFilterPlanMode.Replace },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SecurityFilterPlanMode,
        string
    > _enumToString = new()
    {
        { SecurityFilterPlanMode.Sanitize, "sanitize" },
        { SecurityFilterPlanMode.Reject, "reject" },
        { SecurityFilterPlanMode.Replace, "replace" },
    };

    public override SecurityFilterPlanMode Read(
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
        SecurityFilterPlanMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SecurityFilterPlanMode ReadAsPropertyName(
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
        SecurityFilterPlanMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
