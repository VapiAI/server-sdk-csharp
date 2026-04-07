using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateTokenDtoTagSerializer))]
public enum UpdateTokenDtoTag
{
    [EnumMember(Value = "private")]
    Private,

    [EnumMember(Value = "public")]
    Public,
}

internal class UpdateTokenDtoTagSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateTokenDtoTag>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateTokenDtoTag
    > _stringToEnum = new()
    {
        { "private", UpdateTokenDtoTag.Private },
        { "public", UpdateTokenDtoTag.Public },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateTokenDtoTag,
        string
    > _enumToString = new()
    {
        { UpdateTokenDtoTag.Private, "private" },
        { UpdateTokenDtoTag.Public, "public" },
    };

    public override UpdateTokenDtoTag Read(
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
        UpdateTokenDtoTag value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateTokenDtoTag ReadAsPropertyName(
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
        UpdateTokenDtoTag value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
