using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficAllocationAllocationIntentSerializer))]
public enum TrafficAllocationAllocationIntent
{
    [EnumMember(Value = "follow-latest")]
    FollowLatest,

    [EnumMember(Value = "explicit")]
    Explicit,
}

internal class TrafficAllocationAllocationIntentSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficAllocationAllocationIntent>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficAllocationAllocationIntent
    > _stringToEnum = new()
    {
        { "follow-latest", TrafficAllocationAllocationIntent.FollowLatest },
        { "explicit", TrafficAllocationAllocationIntent.Explicit },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficAllocationAllocationIntent,
        string
    > _enumToString = new()
    {
        { TrafficAllocationAllocationIntent.FollowLatest, "follow-latest" },
        { TrafficAllocationAllocationIntent.Explicit, "explicit" },
    };

    public override TrafficAllocationAllocationIntent Read(
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
        TrafficAllocationAllocationIntent value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficAllocationAllocationIntent ReadAsPropertyName(
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
        TrafficAllocationAllocationIntent value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
