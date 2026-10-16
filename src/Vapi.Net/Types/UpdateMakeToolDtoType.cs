using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateMakeToolDtoTypeSerializer))]
public enum UpdateMakeToolDtoType
{
    [EnumMember(Value = "make")]
    Make,
}

internal class UpdateMakeToolDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateMakeToolDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateMakeToolDtoType
    > _stringToEnum = new() { { "make", UpdateMakeToolDtoType.Make } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateMakeToolDtoType,
        string
    > _enumToString = new() { { UpdateMakeToolDtoType.Make, "make" } };

    public override UpdateMakeToolDtoType Read(
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
        UpdateMakeToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateMakeToolDtoType ReadAsPropertyName(
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
        UpdateMakeToolDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
