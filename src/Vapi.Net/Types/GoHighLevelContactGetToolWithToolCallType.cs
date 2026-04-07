using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoHighLevelContactGetToolWithToolCallTypeSerializer))]
public enum GoHighLevelContactGetToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.contact.get")]
    GohighlevelContactGet,
}

internal class GoHighLevelContactGetToolWithToolCallTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoHighLevelContactGetToolWithToolCallType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoHighLevelContactGetToolWithToolCallType
    > _stringToEnum = new()
    {
        {
            "gohighlevel.contact.get",
            GoHighLevelContactGetToolWithToolCallType.GohighlevelContactGet
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoHighLevelContactGetToolWithToolCallType,
        string
    > _enumToString = new()
    {
        {
            GoHighLevelContactGetToolWithToolCallType.GohighlevelContactGet,
            "gohighlevel.contact.get"
        },
    };

    public override GoHighLevelContactGetToolWithToolCallType Read(
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
        GoHighLevelContactGetToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoHighLevelContactGetToolWithToolCallType ReadAsPropertyName(
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
        GoHighLevelContactGetToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
