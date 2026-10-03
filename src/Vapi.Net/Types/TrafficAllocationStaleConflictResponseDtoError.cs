using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficAllocationStaleConflictResponseDtoErrorSerializer))]
public enum TrafficAllocationStaleConflictResponseDtoError
{
    [EnumMember(Value = "stale_allocation")]
    StaleAllocation,
}

internal class TrafficAllocationStaleConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficAllocationStaleConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficAllocationStaleConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "stale_allocation", TrafficAllocationStaleConflictResponseDtoError.StaleAllocation },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficAllocationStaleConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { TrafficAllocationStaleConflictResponseDtoError.StaleAllocation, "stale_allocation" },
    };

    public override TrafficAllocationStaleConflictResponseDtoError Read(
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
        TrafficAllocationStaleConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficAllocationStaleConflictResponseDtoError ReadAsPropertyName(
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
        TrafficAllocationStaleConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
