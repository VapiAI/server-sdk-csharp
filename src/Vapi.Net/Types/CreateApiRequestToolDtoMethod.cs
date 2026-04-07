using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateApiRequestToolDtoMethodSerializer))]
public enum CreateApiRequestToolDtoMethod
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

internal class CreateApiRequestToolDtoMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateApiRequestToolDtoMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateApiRequestToolDtoMethod
    > _stringToEnum = new()
    {
        { "POST", CreateApiRequestToolDtoMethod.Post },
        { "GET", CreateApiRequestToolDtoMethod.Get },
        { "PUT", CreateApiRequestToolDtoMethod.Put },
        { "PATCH", CreateApiRequestToolDtoMethod.Patch },
        { "DELETE", CreateApiRequestToolDtoMethod.Delete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateApiRequestToolDtoMethod,
        string
    > _enumToString = new()
    {
        { CreateApiRequestToolDtoMethod.Post, "POST" },
        { CreateApiRequestToolDtoMethod.Get, "GET" },
        { CreateApiRequestToolDtoMethod.Put, "PUT" },
        { CreateApiRequestToolDtoMethod.Patch, "PATCH" },
        { CreateApiRequestToolDtoMethod.Delete, "DELETE" },
    };

    public override CreateApiRequestToolDtoMethod Read(
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
        CreateApiRequestToolDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateApiRequestToolDtoMethod ReadAsPropertyName(
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
        CreateApiRequestToolDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
