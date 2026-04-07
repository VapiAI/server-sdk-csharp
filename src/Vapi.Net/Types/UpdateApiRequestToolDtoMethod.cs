using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateApiRequestToolDtoMethodSerializer))]
public enum UpdateApiRequestToolDtoMethod
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

internal class UpdateApiRequestToolDtoMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateApiRequestToolDtoMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateApiRequestToolDtoMethod
    > _stringToEnum = new()
    {
        { "POST", UpdateApiRequestToolDtoMethod.Post },
        { "GET", UpdateApiRequestToolDtoMethod.Get },
        { "PUT", UpdateApiRequestToolDtoMethod.Put },
        { "PATCH", UpdateApiRequestToolDtoMethod.Patch },
        { "DELETE", UpdateApiRequestToolDtoMethod.Delete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateApiRequestToolDtoMethod,
        string
    > _enumToString = new()
    {
        { UpdateApiRequestToolDtoMethod.Post, "POST" },
        { UpdateApiRequestToolDtoMethod.Get, "GET" },
        { UpdateApiRequestToolDtoMethod.Put, "PUT" },
        { UpdateApiRequestToolDtoMethod.Patch, "PATCH" },
        { UpdateApiRequestToolDtoMethod.Delete, "DELETE" },
    };

    public override UpdateApiRequestToolDtoMethod Read(
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
        UpdateApiRequestToolDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateApiRequestToolDtoMethod ReadAsPropertyName(
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
        UpdateApiRequestToolDtoMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
