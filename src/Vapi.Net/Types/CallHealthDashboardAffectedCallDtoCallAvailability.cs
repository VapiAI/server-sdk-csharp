using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardAffectedCallDtoCallAvailabilitySerializer))]
public enum CallHealthDashboardAffectedCallDtoCallAvailability
{
    [EnumMember(Value = "available")]
    Available,

    [EnumMember(Value = "unavailable")]
    Unavailable,
}

internal class CallHealthDashboardAffectedCallDtoCallAvailabilitySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardAffectedCallDtoCallAvailability>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardAffectedCallDtoCallAvailability
    > _stringToEnum = new()
    {
        { "available", CallHealthDashboardAffectedCallDtoCallAvailability.Available },
        { "unavailable", CallHealthDashboardAffectedCallDtoCallAvailability.Unavailable },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardAffectedCallDtoCallAvailability,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardAffectedCallDtoCallAvailability.Available, "available" },
        { CallHealthDashboardAffectedCallDtoCallAvailability.Unavailable, "unavailable" },
    };

    public override CallHealthDashboardAffectedCallDtoCallAvailability Read(
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
        CallHealthDashboardAffectedCallDtoCallAvailability value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardAffectedCallDtoCallAvailability ReadAsPropertyName(
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
        CallHealthDashboardAffectedCallDtoCallAvailability value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
