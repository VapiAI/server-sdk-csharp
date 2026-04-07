using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(HmacAuthenticationPlanSignatureEncodingSerializer))]
public enum HmacAuthenticationPlanSignatureEncoding
{
    [EnumMember(Value = "hex")]
    Hex,

    [EnumMember(Value = "base64")]
    Base64,
}

internal class HmacAuthenticationPlanSignatureEncodingSerializer
    : global::System.Text.Json.Serialization.JsonConverter<HmacAuthenticationPlanSignatureEncoding>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        HmacAuthenticationPlanSignatureEncoding
    > _stringToEnum = new()
    {
        { "hex", HmacAuthenticationPlanSignatureEncoding.Hex },
        { "base64", HmacAuthenticationPlanSignatureEncoding.Base64 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        HmacAuthenticationPlanSignatureEncoding,
        string
    > _enumToString = new()
    {
        { HmacAuthenticationPlanSignatureEncoding.Hex, "hex" },
        { HmacAuthenticationPlanSignatureEncoding.Base64, "base64" },
    };

    public override HmacAuthenticationPlanSignatureEncoding Read(
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
        HmacAuthenticationPlanSignatureEncoding value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override HmacAuthenticationPlanSignatureEncoding ReadAsPropertyName(
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
        HmacAuthenticationPlanSignatureEncoding value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
