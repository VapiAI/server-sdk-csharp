using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiReasonerModelSerializer))]
public enum OpenAiReasonerModel
{
    [EnumMember(Value = "gpt-5.6-sol")]
    Gpt56Sol,

    [EnumMember(Value = "gpt-5.6-terra")]
    Gpt56Terra,

    [EnumMember(Value = "gpt-5.6-luna")]
    Gpt56Luna,
}

internal class OpenAiReasonerModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiReasonerModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiReasonerModel
    > _stringToEnum = new()
    {
        { "gpt-5.6-sol", OpenAiReasonerModel.Gpt56Sol },
        { "gpt-5.6-terra", OpenAiReasonerModel.Gpt56Terra },
        { "gpt-5.6-luna", OpenAiReasonerModel.Gpt56Luna },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiReasonerModel,
        string
    > _enumToString = new()
    {
        { OpenAiReasonerModel.Gpt56Sol, "gpt-5.6-sol" },
        { OpenAiReasonerModel.Gpt56Terra, "gpt-5.6-terra" },
        { OpenAiReasonerModel.Gpt56Luna, "gpt-5.6-luna" },
    };

    public override OpenAiReasonerModel Read(
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
        OpenAiReasonerModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiReasonerModel ReadAsPropertyName(
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
        OpenAiReasonerModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
