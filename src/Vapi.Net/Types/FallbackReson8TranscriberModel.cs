using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackReson8TranscriberModelSerializer))]
public enum FallbackReson8TranscriberModel
{
    [EnumMember(Value = "turns")]
    Turns,
}

internal class FallbackReson8TranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackReson8TranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackReson8TranscriberModel
    > _stringToEnum = new() { { "turns", FallbackReson8TranscriberModel.Turns } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackReson8TranscriberModel,
        string
    > _enumToString = new() { { FallbackReson8TranscriberModel.Turns, "turns" } };

    public override FallbackReson8TranscriberModel Read(
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
        FallbackReson8TranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackReson8TranscriberModel ReadAsPropertyName(
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
        FallbackReson8TranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
