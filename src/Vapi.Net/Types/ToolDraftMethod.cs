using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolDraftMethodSerializer))]
public enum ToolDraftMethod
{
    [EnumMember(Value = "POST")]
    Post,

    [EnumMember(Value = "GET")]
    Get,

    [EnumMember(Value = "PUT")]
    Put,

    [EnumMember(Value = "PATCH")]
    Patch,

    [EnumMember(Value = "DELETE")]
    Delete,
}

internal class ToolDraftMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolDraftMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolDraftMethod
    > _stringToEnum = new()
    {
        { "POST", ToolDraftMethod.Post },
        { "GET", ToolDraftMethod.Get },
        { "PUT", ToolDraftMethod.Put },
        { "PATCH", ToolDraftMethod.Patch },
        { "DELETE", ToolDraftMethod.Delete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolDraftMethod,
        string
    > _enumToString = new()
    {
        { ToolDraftMethod.Post, "POST" },
        { ToolDraftMethod.Get, "GET" },
        { ToolDraftMethod.Put, "PUT" },
        { ToolDraftMethod.Patch, "PATCH" },
        { ToolDraftMethod.Delete, "DELETE" },
    };

    public override ToolDraftMethod Read(
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
        ToolDraftMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolDraftMethod ReadAsPropertyName(
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
        ToolDraftMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
