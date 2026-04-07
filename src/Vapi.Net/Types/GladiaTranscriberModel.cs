using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GladiaTranscriberModelSerializer))]
public enum GladiaTranscriberModel
{
    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "accurate")]
    Accurate,

    [EnumMember(Value = "solaria-1")]
    Solaria1,
}

internal class GladiaTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GladiaTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GladiaTranscriberModel
    > _stringToEnum = new()
    {
        { "fast", GladiaTranscriberModel.Fast },
        { "accurate", GladiaTranscriberModel.Accurate },
        { "solaria-1", GladiaTranscriberModel.Solaria1 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GladiaTranscriberModel,
        string
    > _enumToString = new()
    {
        { GladiaTranscriberModel.Fast, "fast" },
        { GladiaTranscriberModel.Accurate, "accurate" },
        { GladiaTranscriberModel.Solaria1, "solaria-1" },
    };

    public override GladiaTranscriberModel Read(
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
        GladiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GladiaTranscriberModel ReadAsPropertyName(
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
        GladiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
