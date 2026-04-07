using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CustomLlmModelMetadataSendModeSerializer))]
public enum CustomLlmModelMetadataSendMode
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "variable")]
    Variable,

    [EnumMember(Value = "destructured")]
    Destructured,
}

internal class CustomLlmModelMetadataSendModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CustomLlmModelMetadataSendMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CustomLlmModelMetadataSendMode
    > _stringToEnum = new()
    {
        { "off", CustomLlmModelMetadataSendMode.Off },
        { "variable", CustomLlmModelMetadataSendMode.Variable },
        { "destructured", CustomLlmModelMetadataSendMode.Destructured },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CustomLlmModelMetadataSendMode,
        string
    > _enumToString = new()
    {
        { CustomLlmModelMetadataSendMode.Off, "off" },
        { CustomLlmModelMetadataSendMode.Variable, "variable" },
        { CustomLlmModelMetadataSendMode.Destructured, "destructured" },
    };

    public override CustomLlmModelMetadataSendMode Read(
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
        CustomLlmModelMetadataSendMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CustomLlmModelMetadataSendMode ReadAsPropertyName(
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
        CustomLlmModelMetadataSendMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
