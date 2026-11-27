using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficAllocationActorTypeSerializer))]
public enum TrafficAllocationActorType
{
    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "api-key")]
    ApiKey,

    [EnumMember(Value = "system")]
    System,
}

internal class TrafficAllocationActorTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficAllocationActorType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficAllocationActorType
    > _stringToEnum = new()
    {
        { "user", TrafficAllocationActorType.User },
        { "api-key", TrafficAllocationActorType.ApiKey },
        { "system", TrafficAllocationActorType.System },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficAllocationActorType,
        string
    > _enumToString = new()
    {
        { TrafficAllocationActorType.User, "user" },
        { TrafficAllocationActorType.ApiKey, "api-key" },
        { TrafficAllocationActorType.System, "system" },
    };

    public override TrafficAllocationActorType Read(
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
        TrafficAllocationActorType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficAllocationActorType ReadAsPropertyName(
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
        TrafficAllocationActorType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
