using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHookCallEndingOnSerializer))]
public enum CallHookCallEndingOn
{
    [EnumMember(Value = "call.ending")]
    CallEnding,
}

internal class CallHookCallEndingOnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHookCallEndingOn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHookCallEndingOn
    > _stringToEnum = new() { { "call.ending", CallHookCallEndingOn.CallEnding } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHookCallEndingOn,
        string
    > _enumToString = new() { { CallHookCallEndingOn.CallEnding, "call.ending" } };

    public override CallHookCallEndingOn Read(
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
        CallHookCallEndingOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHookCallEndingOn ReadAsPropertyName(
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
        CallHookCallEndingOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
