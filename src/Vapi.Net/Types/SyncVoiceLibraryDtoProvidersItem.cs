using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SyncVoiceLibraryDtoProvidersItemSerializer))]
public enum SyncVoiceLibraryDtoProvidersItem
{
    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "11labs")]
    ElevenLabs,

    [EnumMember(Value = "azure")]
    Azure,

    [EnumMember(Value = "cartesia")]
    Cartesia,

    [EnumMember(Value = "custom-voice")]
    CustomVoice,

    [EnumMember(Value = "deepgram")]
    Deepgram,

    [EnumMember(Value = "hume")]
    Hume,

    [EnumMember(Value = "lmnt")]
    Lmnt,

    [EnumMember(Value = "neuphonic")]
    Neuphonic,

    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "playht")]
    Playht,

    [EnumMember(Value = "rime-ai")]
    RimeAi,

    [EnumMember(Value = "smallest-ai")]
    SmallestAi,

    [EnumMember(Value = "tavus")]
    Tavus,

    [EnumMember(Value = "sesame")]
    Sesame,

    [EnumMember(Value = "inworld")]
    Inworld,

    [EnumMember(Value = "minimax")]
    Minimax,

    [EnumMember(Value = "wellsaid")]
    Wellsaid,

    [EnumMember(Value = "orpheus")]
    Orpheus,
}

internal class SyncVoiceLibraryDtoProvidersItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SyncVoiceLibraryDtoProvidersItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SyncVoiceLibraryDtoProvidersItem
    > _stringToEnum = new()
    {
        { "vapi", SyncVoiceLibraryDtoProvidersItem.Vapi },
        { "11labs", SyncVoiceLibraryDtoProvidersItem.ElevenLabs },
        { "azure", SyncVoiceLibraryDtoProvidersItem.Azure },
        { "cartesia", SyncVoiceLibraryDtoProvidersItem.Cartesia },
        { "custom-voice", SyncVoiceLibraryDtoProvidersItem.CustomVoice },
        { "deepgram", SyncVoiceLibraryDtoProvidersItem.Deepgram },
        { "hume", SyncVoiceLibraryDtoProvidersItem.Hume },
        { "lmnt", SyncVoiceLibraryDtoProvidersItem.Lmnt },
        { "neuphonic", SyncVoiceLibraryDtoProvidersItem.Neuphonic },
        { "openai", SyncVoiceLibraryDtoProvidersItem.Openai },
        { "playht", SyncVoiceLibraryDtoProvidersItem.Playht },
        { "rime-ai", SyncVoiceLibraryDtoProvidersItem.RimeAi },
        { "smallest-ai", SyncVoiceLibraryDtoProvidersItem.SmallestAi },
        { "tavus", SyncVoiceLibraryDtoProvidersItem.Tavus },
        { "sesame", SyncVoiceLibraryDtoProvidersItem.Sesame },
        { "inworld", SyncVoiceLibraryDtoProvidersItem.Inworld },
        { "minimax", SyncVoiceLibraryDtoProvidersItem.Minimax },
        { "wellsaid", SyncVoiceLibraryDtoProvidersItem.Wellsaid },
        { "orpheus", SyncVoiceLibraryDtoProvidersItem.Orpheus },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SyncVoiceLibraryDtoProvidersItem,
        string
    > _enumToString = new()
    {
        { SyncVoiceLibraryDtoProvidersItem.Vapi, "vapi" },
        { SyncVoiceLibraryDtoProvidersItem.ElevenLabs, "11labs" },
        { SyncVoiceLibraryDtoProvidersItem.Azure, "azure" },
        { SyncVoiceLibraryDtoProvidersItem.Cartesia, "cartesia" },
        { SyncVoiceLibraryDtoProvidersItem.CustomVoice, "custom-voice" },
        { SyncVoiceLibraryDtoProvidersItem.Deepgram, "deepgram" },
        { SyncVoiceLibraryDtoProvidersItem.Hume, "hume" },
        { SyncVoiceLibraryDtoProvidersItem.Lmnt, "lmnt" },
        { SyncVoiceLibraryDtoProvidersItem.Neuphonic, "neuphonic" },
        { SyncVoiceLibraryDtoProvidersItem.Openai, "openai" },
        { SyncVoiceLibraryDtoProvidersItem.Playht, "playht" },
        { SyncVoiceLibraryDtoProvidersItem.RimeAi, "rime-ai" },
        { SyncVoiceLibraryDtoProvidersItem.SmallestAi, "smallest-ai" },
        { SyncVoiceLibraryDtoProvidersItem.Tavus, "tavus" },
        { SyncVoiceLibraryDtoProvidersItem.Sesame, "sesame" },
        { SyncVoiceLibraryDtoProvidersItem.Inworld, "inworld" },
        { SyncVoiceLibraryDtoProvidersItem.Minimax, "minimax" },
        { SyncVoiceLibraryDtoProvidersItem.Wellsaid, "wellsaid" },
        { SyncVoiceLibraryDtoProvidersItem.Orpheus, "orpheus" },
    };

    public override SyncVoiceLibraryDtoProvidersItem Read(
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
        SyncVoiceLibraryDtoProvidersItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SyncVoiceLibraryDtoProvidersItem ReadAsPropertyName(
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
        SyncVoiceLibraryDtoProvidersItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
