using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGladiaTranscriberModelSerializer))]
public enum FallbackGladiaTranscriberModel
{
    [EnumMember(Value = "fast")]
    Fast,

    [EnumMember(Value = "accurate")]
    Accurate,

    [EnumMember(Value = "solaria-1")]
    Solaria1,
}

internal class FallbackGladiaTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGladiaTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGladiaTranscriberModel
    > _stringToEnum = new()
    {
        { "fast", FallbackGladiaTranscriberModel.Fast },
        { "accurate", FallbackGladiaTranscriberModel.Accurate },
        { "solaria-1", FallbackGladiaTranscriberModel.Solaria1 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGladiaTranscriberModel,
        string
    > _enumToString = new()
    {
        { FallbackGladiaTranscriberModel.Fast, "fast" },
        { FallbackGladiaTranscriberModel.Accurate, "accurate" },
        { FallbackGladiaTranscriberModel.Solaria1, "solaria-1" },
    };

    public override FallbackGladiaTranscriberModel Read(
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
        FallbackGladiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGladiaTranscriberModel ReadAsPropertyName(
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
        FallbackGladiaTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
