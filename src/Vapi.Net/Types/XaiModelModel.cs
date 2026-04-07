using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(XaiModelModelSerializer))]
public enum XaiModelModel
{
    [EnumMember(Value = "grok-beta")]
    GrokBeta,

    [EnumMember(Value = "grok-2")]
    Grok2,

    [EnumMember(Value = "grok-3")]
    Grok3,

    [EnumMember(Value = "grok-4-fast-reasoning")]
    Grok4FastReasoning,

    [EnumMember(Value = "grok-4-fast-non-reasoning")]
    Grok4FastNonReasoning,
}

internal class XaiModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<XaiModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        XaiModelModel
    > _stringToEnum = new()
    {
        { "grok-beta", XaiModelModel.GrokBeta },
        { "grok-2", XaiModelModel.Grok2 },
        { "grok-3", XaiModelModel.Grok3 },
        { "grok-4-fast-reasoning", XaiModelModel.Grok4FastReasoning },
        { "grok-4-fast-non-reasoning", XaiModelModel.Grok4FastNonReasoning },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        XaiModelModel,
        string
    > _enumToString = new()
    {
        { XaiModelModel.GrokBeta, "grok-beta" },
        { XaiModelModel.Grok2, "grok-2" },
        { XaiModelModel.Grok3, "grok-3" },
        { XaiModelModel.Grok4FastReasoning, "grok-4-fast-reasoning" },
        { XaiModelModel.Grok4FastNonReasoning, "grok-4-fast-non-reasoning" },
    };

    public override XaiModelModel Read(
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
        XaiModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override XaiModelModel ReadAsPropertyName(
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
        XaiModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
