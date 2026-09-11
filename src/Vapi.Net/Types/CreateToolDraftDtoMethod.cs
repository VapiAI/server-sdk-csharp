using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateToolDraftDtoMethodSerializer))]
public enum CreateToolDraftDtoMethod
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

internal class CreateToolDraftDtoMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateToolDraftDtoMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateToolDraftDtoMethod
    > _stringToEnum = new()
    {
        { "POST", CreateToolDraftDtoMethod.Post },
        { "GET", CreateToolDraftDtoMethod.Get },
        { "PUT", CreateToolDraftDtoMethod.Put },
        { "PATCH", CreateToolDraftDtoMethod.Patch },
        { "DELETE", CreateToolDraftDtoMethod.Delete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateToolDraftDtoMethod,
        string
    > _enumToString = new()
    {
        { CreateToolDraftDtoMethod.Post, "POST" },
        { CreateToolDraftDtoMethod.Get, "GET" },
        { CreateToolDraftDtoMethod.Put, "PUT" },
        { CreateToolDraftDtoMethod.Patch, "PATCH" },
        { CreateToolDraftDtoMethod.Delete, "DELETE" },
    };

    public override CreateToolDraftDtoMethod Read(
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
        CreateToolDraftDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateToolDraftDtoMethod ReadAsPropertyName(
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
        CreateToolDraftDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
