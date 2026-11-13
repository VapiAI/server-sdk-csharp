using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(Reson8TranscriberModelSerializer))]
public enum Reson8TranscriberModel
{
    [EnumMember(Value = "turns")]
    Turns,
}

internal class Reson8TranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<Reson8TranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        Reson8TranscriberModel
    > _stringToEnum = new() { { "turns", Reson8TranscriberModel.Turns } };

    private static readonly global::System.Collections.Generic.Dictionary<
        Reson8TranscriberModel,
        string
    > _enumToString = new() { { Reson8TranscriberModel.Turns, "turns" } };

    public override Reson8TranscriberModel Read(
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
        Reson8TranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override Reson8TranscriberModel ReadAsPropertyName(
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
        Reson8TranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
