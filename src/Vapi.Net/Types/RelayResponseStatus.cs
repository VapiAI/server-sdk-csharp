using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RelayResponseStatusSerializer))]
public enum RelayResponseStatus
{
    [EnumMember(Value = "deliveredLive")]
    DeliveredLive,

    [EnumMember(Value = "deliveredHeadless")]
    DeliveredHeadless,

    [EnumMember(Value = "failed")]
    Failed,
}

internal class RelayResponseStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RelayResponseStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RelayResponseStatus
    > _stringToEnum = new()
    {
        { "deliveredLive", RelayResponseStatus.DeliveredLive },
        { "deliveredHeadless", RelayResponseStatus.DeliveredHeadless },
        { "failed", RelayResponseStatus.Failed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RelayResponseStatus,
        string
    > _enumToString = new()
    {
        { RelayResponseStatus.DeliveredLive, "deliveredLive" },
        { RelayResponseStatus.DeliveredHeadless, "deliveredHeadless" },
        { RelayResponseStatus.Failed, "failed" },
    };

    public override RelayResponseStatus Read(
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
        RelayResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RelayResponseStatus ReadAsPropertyName(
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
        RelayResponseStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
