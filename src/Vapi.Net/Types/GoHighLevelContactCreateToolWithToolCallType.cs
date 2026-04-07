using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoHighLevelContactCreateToolWithToolCallTypeSerializer))]
public enum GoHighLevelContactCreateToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.contact.create")]
    GohighlevelContactCreate,
}

internal class GoHighLevelContactCreateToolWithToolCallTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoHighLevelContactCreateToolWithToolCallType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoHighLevelContactCreateToolWithToolCallType
    > _stringToEnum = new()
    {
        {
            "gohighlevel.contact.create",
            GoHighLevelContactCreateToolWithToolCallType.GohighlevelContactCreate
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoHighLevelContactCreateToolWithToolCallType,
        string
    > _enumToString = new()
    {
        {
            GoHighLevelContactCreateToolWithToolCallType.GohighlevelContactCreate,
            "gohighlevel.contact.create"
        },
    };

    public override GoHighLevelContactCreateToolWithToolCallType Read(
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
        GoHighLevelContactCreateToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoHighLevelContactCreateToolWithToolCallType ReadAsPropertyName(
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
        GoHighLevelContactCreateToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
