using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackDeepgramTranscriberRedactionItemSerializer))]
public enum FallbackDeepgramTranscriberRedactionItem
{
    [EnumMember(Value = "pci")]
    Pci,

    [EnumMember(Value = "pii")]
    Pii,

    [EnumMember(Value = "phi")]
    Phi,

    [EnumMember(Value = "numbers")]
    Numbers,
}

internal class FallbackDeepgramTranscriberRedactionItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackDeepgramTranscriberRedactionItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackDeepgramTranscriberRedactionItem
    > _stringToEnum = new()
    {
        { "pci", FallbackDeepgramTranscriberRedactionItem.Pci },
        { "pii", FallbackDeepgramTranscriberRedactionItem.Pii },
        { "phi", FallbackDeepgramTranscriberRedactionItem.Phi },
        { "numbers", FallbackDeepgramTranscriberRedactionItem.Numbers },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackDeepgramTranscriberRedactionItem,
        string
    > _enumToString = new()
    {
        { FallbackDeepgramTranscriberRedactionItem.Pci, "pci" },
        { FallbackDeepgramTranscriberRedactionItem.Pii, "pii" },
        { FallbackDeepgramTranscriberRedactionItem.Phi, "phi" },
        { FallbackDeepgramTranscriberRedactionItem.Numbers, "numbers" },
    };

    public override FallbackDeepgramTranscriberRedactionItem Read(
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
        FallbackDeepgramTranscriberRedactionItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackDeepgramTranscriberRedactionItem ReadAsPropertyName(
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
        FallbackDeepgramTranscriberRedactionItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
