using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficAllocationVersionConflictResponseDtoErrorSerializer))]
public enum TrafficAllocationVersionConflictResponseDtoError
{
    [EnumMember(Value = "version_in_governing_allocation")]
    VersionInGoverningAllocation,
}

internal class TrafficAllocationVersionConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficAllocationVersionConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficAllocationVersionConflictResponseDtoError
    > _stringToEnum = new()
    {
        {
            "version_in_governing_allocation",
            TrafficAllocationVersionConflictResponseDtoError.VersionInGoverningAllocation
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficAllocationVersionConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        {
            TrafficAllocationVersionConflictResponseDtoError.VersionInGoverningAllocation,
            "version_in_governing_allocation"
        },
    };

    public override TrafficAllocationVersionConflictResponseDtoError Read(
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
        TrafficAllocationVersionConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficAllocationVersionConflictResponseDtoError ReadAsPropertyName(
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
        TrafficAllocationVersionConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
