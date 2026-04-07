using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ProviderResourceControllerGetProviderResourceRequestResourceNameSerializer))]
public enum ProviderResourceControllerGetProviderResourceRequestResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}

internal class ProviderResourceControllerGetProviderResourceRequestResourceNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceControllerGetProviderResourceRequestResourceName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceControllerGetProviderResourceRequestResourceName
    > _stringToEnum = new()
    {
        {
            "pronunciation-dictionary",
            ProviderResourceControllerGetProviderResourceRequestResourceName.PronunciationDictionary
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceControllerGetProviderResourceRequestResourceName,
        string
    > _enumToString = new()
    {
        {
            ProviderResourceControllerGetProviderResourceRequestResourceName.PronunciationDictionary,
            "pronunciation-dictionary"
        },
    };

    public override ProviderResourceControllerGetProviderResourceRequestResourceName Read(
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
        ProviderResourceControllerGetProviderResourceRequestResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceControllerGetProviderResourceRequestResourceName ReadAsPropertyName(
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
        ProviderResourceControllerGetProviderResourceRequestResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
