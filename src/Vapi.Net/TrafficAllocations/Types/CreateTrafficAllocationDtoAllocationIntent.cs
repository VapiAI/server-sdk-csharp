using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateTrafficAllocationDtoAllocationIntentSerializer))]
public enum CreateTrafficAllocationDtoAllocationIntent
{
    [EnumMember(Value = "follow-latest")]
    FollowLatest,

    [EnumMember(Value = "explicit")]
    Explicit,
}

internal class CreateTrafficAllocationDtoAllocationIntentSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateTrafficAllocationDtoAllocationIntent>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateTrafficAllocationDtoAllocationIntent
    > _stringToEnum = new()
    {
        { "follow-latest", CreateTrafficAllocationDtoAllocationIntent.FollowLatest },
        { "explicit", CreateTrafficAllocationDtoAllocationIntent.Explicit },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateTrafficAllocationDtoAllocationIntent,
        string
    > _enumToString = new()
    {
        { CreateTrafficAllocationDtoAllocationIntent.FollowLatest, "follow-latest" },
        { CreateTrafficAllocationDtoAllocationIntent.Explicit, "explicit" },
    };

    public override CreateTrafficAllocationDtoAllocationIntent Read(
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
        CreateTrafficAllocationDtoAllocationIntent value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateTrafficAllocationDtoAllocationIntent ReadAsPropertyName(
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
        CreateTrafficAllocationDtoAllocationIntent value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
