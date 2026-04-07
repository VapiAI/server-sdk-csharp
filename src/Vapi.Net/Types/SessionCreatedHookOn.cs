using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SessionCreatedHookOnSerializer))]
public enum SessionCreatedHookOn
{
    [EnumMember(Value = "session.created")]
    SessionCreated,
}

internal class SessionCreatedHookOnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SessionCreatedHookOn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SessionCreatedHookOn
    > _stringToEnum = new() { { "session.created", SessionCreatedHookOn.SessionCreated } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SessionCreatedHookOn,
        string
    > _enumToString = new() { { SessionCreatedHookOn.SessionCreated, "session.created" } };

    public override SessionCreatedHookOn Read(
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
        SessionCreatedHookOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SessionCreatedHookOn ReadAsPropertyName(
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
        SessionCreatedHookOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
