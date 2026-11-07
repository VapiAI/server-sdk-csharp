using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateGhlToolDtoTypeSerializer))]
public enum UpdateGhlToolDtoType
{
    [EnumMember(Value = "ghl")]
    Ghl,
}

internal class UpdateGhlToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateGhlToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateGhlToolDtoType
    > _stringToEnum = new() { { "ghl", UpdateGhlToolDtoType.Ghl } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateGhlToolDtoType,
        string
    > _enumToString = new() { { UpdateGhlToolDtoType.Ghl, "ghl" } };

    public override UpdateGhlToolDtoType Read(
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
        UpdateGhlToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateGhlToolDtoType ReadAsPropertyName(
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
        UpdateGhlToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
