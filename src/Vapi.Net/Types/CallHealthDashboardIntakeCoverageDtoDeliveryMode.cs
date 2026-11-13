using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHealthDashboardIntakeCoverageDtoDeliveryModeSerializer))]
public enum CallHealthDashboardIntakeCoverageDtoDeliveryMode
{
    [EnumMember(Value = "bestEffort")]
    BestEffort,
}

internal class CallHealthDashboardIntakeCoverageDtoDeliveryModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHealthDashboardIntakeCoverageDtoDeliveryMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHealthDashboardIntakeCoverageDtoDeliveryMode
    > _stringToEnum = new()
    {
        { "bestEffort", CallHealthDashboardIntakeCoverageDtoDeliveryMode.BestEffort },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHealthDashboardIntakeCoverageDtoDeliveryMode,
        string
    > _enumToString = new()
    {
        { CallHealthDashboardIntakeCoverageDtoDeliveryMode.BestEffort, "bestEffort" },
    };

    public override CallHealthDashboardIntakeCoverageDtoDeliveryMode Read(
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
        CallHealthDashboardIntakeCoverageDtoDeliveryMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHealthDashboardIntakeCoverageDtoDeliveryMode ReadAsPropertyName(
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
        CallHealthDashboardIntakeCoverageDtoDeliveryMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
