using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ApiRequestToolMethodSerializer))]
public enum ApiRequestToolMethod
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

internal class ApiRequestToolMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ApiRequestToolMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ApiRequestToolMethod
    > _stringToEnum = new()
    {
        { "POST", ApiRequestToolMethod.Post },
        { "GET", ApiRequestToolMethod.Get },
        { "PUT", ApiRequestToolMethod.Put },
        { "PATCH", ApiRequestToolMethod.Patch },
        { "DELETE", ApiRequestToolMethod.Delete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ApiRequestToolMethod,
        string
    > _enumToString = new()
    {
        { ApiRequestToolMethod.Post, "POST" },
        { ApiRequestToolMethod.Get, "GET" },
        { ApiRequestToolMethod.Put, "PUT" },
        { ApiRequestToolMethod.Patch, "PATCH" },
        { ApiRequestToolMethod.Delete, "DELETE" },
    };

    public override ApiRequestToolMethod Read(
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
        ApiRequestToolMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ApiRequestToolMethod ReadAsPropertyName(
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
        ApiRequestToolMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
