using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(
    typeof(ProviderResourceControllerCreateProviderResourceRequestResourceNameSerializer)
)]
public enum ProviderResourceControllerCreateProviderResourceRequestResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}

internal class ProviderResourceControllerCreateProviderResourceRequestResourceNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerCreateProviderResourceRequestResourceName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerCreateProviderResourceRequestResourceName
    > _stringToEnum = new()
    {
        {
            "pronunciation-dictionary",
            ProviderResourceControllerCreateProviderResourceRequestResourceName.PronunciationDictionary
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerCreateProviderResourceRequestResourceName,
        string
    > _enumToString = new()
    {
        {
            ProviderResourceControllerCreateProviderResourceRequestResourceName.PronunciationDictionary,
            "pronunciation-dictionary"
        },
    };

    public override ProviderResourceControllerCreateProviderResourceRequestResourceName Read(
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
        ProviderResourceControllerCreateProviderResourceRequestResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerCreateProviderResourceRequestResourceName ReadAsPropertyName(
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
        ProviderResourceControllerCreateProviderResourceRequestResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
