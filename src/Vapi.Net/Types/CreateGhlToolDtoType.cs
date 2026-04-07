using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateGhlToolDtoTypeSerializer))]
public enum CreateGhlToolDtoType
{
    [EnumMember(Value = "ghl")]
    Ghl,
}

internal class CreateGhlToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateGhlToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateGhlToolDtoType
    > _stringToEnum = new() { { "ghl", CreateGhlToolDtoType.Ghl } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateGhlToolDtoType,
        string
    > _enumToString = new() { { CreateGhlToolDtoType.Ghl, "ghl" } };

    public override CreateGhlToolDtoType Read(
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
        CreateGhlToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateGhlToolDtoType ReadAsPropertyName(
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
        CreateGhlToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
