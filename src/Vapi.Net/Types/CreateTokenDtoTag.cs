using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateTokenDtoTagSerializer))]
public enum CreateTokenDtoTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}

internal class CreateTokenDtoTagSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateTokenDtoTag>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateTokenDtoTag
    > _stringToEnum = new()
    {
        { "private", CreateTokenDtoTag.Private },
        { "public", CreateTokenDtoTag.Public },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateTokenDtoTag,
        string
    > _enumToString = new()
    {
        { CreateTokenDtoTag.Private, "private" },
        { CreateTokenDtoTag.Public, "public" },
    };

    public override CreateTokenDtoTag Read(
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
        CreateTokenDtoTag value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateTokenDtoTag ReadAsPropertyName(
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
        CreateTokenDtoTag value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
