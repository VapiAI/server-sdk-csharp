using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureVoiceIdEnumSerializer))]
public enum AzureVoiceIdEnum
{
    [EnumMember(Value = "andrew")]
    Andrew,

    [EnumMember(Value = "brian")]
    Brian,

    [EnumMember(Value = "emma")]
    Emma,
}

internal class AzureVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureVoiceIdEnum
    > _stringToEnum = new()
    {
        { "andrew", AzureVoiceIdEnum.Andrew },
        { "brian", AzureVoiceIdEnum.Brian },
        { "emma", AzureVoiceIdEnum.Emma },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { AzureVoiceIdEnum.Andrew, "andrew" },
        { AzureVoiceIdEnum.Brian, "brian" },
        { AzureVoiceIdEnum.Emma, "emma" },
    };

    public override AzureVoiceIdEnum Read(
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
        AzureVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureVoiceIdEnum ReadAsPropertyName(
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
        AzureVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
