using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnEventsTableTableSerializer))]
public enum JsonQueryOnEventsTableTable
{
    [EnumMember(Value = "events")]
    Events,
}

internal class JsonQueryOnEventsTableTableSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnEventsTableTable>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnEventsTableTable
    > _stringToEnum = new() { { "events", JsonQueryOnEventsTableTable.Events } };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnEventsTableTable,
        string
    > _enumToString = new() { { JsonQueryOnEventsTableTable.Events, "events" } };

    public override JsonQueryOnEventsTableTable Read(
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
        JsonQueryOnEventsTableTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnEventsTableTable ReadAsPropertyName(
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
        JsonQueryOnEventsTableTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
