using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateToolDraftDtoMethodSerializer))]
public enum UpdateToolDraftDtoMethod
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

internal class UpdateToolDraftDtoMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateToolDraftDtoMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateToolDraftDtoMethod
    > _stringToEnum = new()
    {
        { "POST", UpdateToolDraftDtoMethod.Post },
        { "GET", UpdateToolDraftDtoMethod.Get },
        { "PUT", UpdateToolDraftDtoMethod.Put },
        { "PATCH", UpdateToolDraftDtoMethod.Patch },
        { "DELETE", UpdateToolDraftDtoMethod.Delete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateToolDraftDtoMethod,
        string
    > _enumToString = new()
    {
        { UpdateToolDraftDtoMethod.Post, "POST" },
        { UpdateToolDraftDtoMethod.Get, "GET" },
        { UpdateToolDraftDtoMethod.Put, "PUT" },
        { UpdateToolDraftDtoMethod.Patch, "PATCH" },
        { UpdateToolDraftDtoMethod.Delete, "DELETE" },
    };

    public override UpdateToolDraftDtoMethod Read(
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
        UpdateToolDraftDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateToolDraftDtoMethod ReadAsPropertyName(
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
        UpdateToolDraftDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
