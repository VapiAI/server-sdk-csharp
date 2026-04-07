using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ProviderResourceResourceNameSerializer))]
public enum ProviderResourceResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}

internal class ProviderResourceResourceNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ProviderResourceResourceName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ProviderResourceResourceName
    > _stringToEnum = new()
    {
        { "pronunciation-dictionary", ProviderResourceResourceName.PronunciationDictionary },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ProviderResourceResourceName,
        string
    > _enumToString = new()
    {
        { ProviderResourceResourceName.PronunciationDictionary, "pronunciation-dictionary" },
    };

    public override ProviderResourceResourceName Read(
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
        ProviderResourceResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ProviderResourceResourceName ReadAsPropertyName(
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
        ProviderResourceResourceName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
