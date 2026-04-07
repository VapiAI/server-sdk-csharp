using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageStatusUpdateTypeSerializer))]
public enum ServerMessageStatusUpdateType
{
    [EnumMember(Value = "status-update")]
    StatusUpdate,
}

internal class ServerMessageStatusUpdateTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageStatusUpdateType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageStatusUpdateType
    > _stringToEnum = new() { { "status-update", ServerMessageStatusUpdateType.StatusUpdate } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageStatusUpdateType,
        string
    > _enumToString = new() { { ServerMessageStatusUpdateType.StatusUpdate, "status-update" } };

    public override ServerMessageStatusUpdateType Read(
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
        ServerMessageStatusUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageStatusUpdateType ReadAsPropertyName(
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
        ServerMessageStatusUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
