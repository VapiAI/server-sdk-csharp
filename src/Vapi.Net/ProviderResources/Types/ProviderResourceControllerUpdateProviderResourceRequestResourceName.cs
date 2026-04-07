using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(
    typeof(ProviderResourceControllerUpdateProviderResourceRequestResourceNameSerializer)
)]
public enum ProviderResourceControllerUpdateProviderResourceRequestResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}

internal class ProviderResourceControllerUpdateProviderResourceRequestResourceNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerUpdateProviderResourceRequestResourceName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerUpdateProviderResourceRequestResourceName
    > _stringToEnum = new()
    {
        {
            "pronunciation-dictionary",
            ProviderResourceControllerUpdateProviderResourceRequestResourceName.PronunciationDictionary
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerUpdateProviderResourceRequestResourceName,
        string
    > _enumToString = new()
    {
        {
            ProviderResourceControllerUpdateProviderResourceRequestResourceName.PronunciationDictionary,
            "pronunciation-dictionary"
        },
    };

    public override ProviderResourceControllerUpdateProviderResourceRequestResourceName Read(
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
        ProviderResourceControllerUpdateProviderResourceRequestResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerUpdateProviderResourceRequestResourceName ReadAsPropertyName(
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
        ProviderResourceControllerUpdateProviderResourceRequestResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
