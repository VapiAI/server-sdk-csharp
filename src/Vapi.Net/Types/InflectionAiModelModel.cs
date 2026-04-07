using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InflectionAiModelModelSerializer))]
public enum InflectionAiModelModel
{
    [EnumMember(Value = "inflection_3_pi")]
    Inflection3Pi,
}

internal class InflectionAiModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InflectionAiModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InflectionAiModelModel
    > _stringToEnum = new() { { "inflection_3_pi", InflectionAiModelModel.Inflection3Pi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        InflectionAiModelModel,
        string
    > _enumToString = new() { { InflectionAiModelModel.Inflection3Pi, "inflection_3_pi" } };

    public override InflectionAiModelModel Read(
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
        InflectionAiModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InflectionAiModelModel ReadAsPropertyName(
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
        InflectionAiModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
