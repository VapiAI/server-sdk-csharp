using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(HmacAuthenticationPlanAlgorithmSerializer))]
public enum HmacAuthenticationPlanAlgorithm
{
    [EnumMember(Value = "sha256")]
    Sha256,

    [EnumMember(Value = "sha512")]
    Sha512,

    [EnumMember(Value = "sha1")]
    Sha1,
}

internal class HmacAuthenticationPlanAlgorithmSerializer
    : global::System.Text.Json.Serialization.JsonConverter<HmacAuthenticationPlanAlgorithm>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        HmacAuthenticationPlanAlgorithm
    > _stringToEnum = new()
    {
        { "sha256", HmacAuthenticationPlanAlgorithm.Sha256 },
        { "sha512", HmacAuthenticationPlanAlgorithm.Sha512 },
        { "sha1", HmacAuthenticationPlanAlgorithm.Sha1 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        HmacAuthenticationPlanAlgorithm,
        string
    > _enumToString = new()
    {
        { HmacAuthenticationPlanAlgorithm.Sha256, "sha256" },
        { HmacAuthenticationPlanAlgorithm.Sha512, "sha512" },
        { HmacAuthenticationPlanAlgorithm.Sha1, "sha1" },
    };

    public override HmacAuthenticationPlanAlgorithm Read(
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
        HmacAuthenticationPlanAlgorithm value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override HmacAuthenticationPlanAlgorithm ReadAsPropertyName(
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
        HmacAuthenticationPlanAlgorithm value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
