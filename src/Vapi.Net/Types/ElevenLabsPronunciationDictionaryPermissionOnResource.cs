using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ElevenLabsPronunciationDictionaryPermissionOnResourceSerializer))]
public enum ElevenLabsPronunciationDictionaryPermissionOnResource
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}

internal class ElevenLabsPronunciationDictionaryPermissionOnResourceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ElevenLabsPronunciationDictionaryPermissionOnResource>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ElevenLabsPronunciationDictionaryPermissionOnResource
    > _stringToEnum = new()
    {
        { "admin", ElevenLabsPronunciationDictionaryPermissionOnResource.Admin },
        { "editor", ElevenLabsPronunciationDictionaryPermissionOnResource.Editor },
        { "viewer", ElevenLabsPronunciationDictionaryPermissionOnResource.Viewer },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ElevenLabsPronunciationDictionaryPermissionOnResource,
        string
    > _enumToString = new()
    {
        { ElevenLabsPronunciationDictionaryPermissionOnResource.Admin, "admin" },
        { ElevenLabsPronunciationDictionaryPermissionOnResource.Editor, "editor" },
        { ElevenLabsPronunciationDictionaryPermissionOnResource.Viewer, "viewer" },
    };

    public override ElevenLabsPronunciationDictionaryPermissionOnResource Read(
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
        ElevenLabsPronunciationDictionaryPermissionOnResource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ElevenLabsPronunciationDictionaryPermissionOnResource ReadAsPropertyName(
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
        ElevenLabsPronunciationDictionaryPermissionOnResource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
