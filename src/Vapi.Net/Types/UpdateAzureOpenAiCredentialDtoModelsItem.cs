using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAzureOpenAiCredentialDtoModelsItemSerializer))]
public enum UpdateAzureOpenAiCredentialDtoModelsItem
{
    [EnumMember(Value = "gpt-5.4")]
    Gpt54,

    [EnumMember(Value = "gpt-5.4-mini")]
    Gpt54Mini,

    [EnumMember(Value = "gpt-5.4-nano")]
    Gpt54Nano,

    [EnumMember(Value = "gpt-5.2")]
    Gpt52,

    [EnumMember(Value = "gpt-5.2-chat")]
    Gpt52Chat,

    [EnumMember(Value = "gpt-5.1")]
    Gpt51,

    [EnumMember(Value = "gpt-5.1-chat")]
    Gpt51Chat,

    [EnumMember(Value = "gpt-5")]
    Gpt5,

    [EnumMember(Value = "gpt-5-mini")]
    Gpt5Mini,

    [EnumMember(Value = "gpt-5-nano")]
    Gpt5Nano,

    [EnumMember(Value = "gpt-4.1-2025-04-14")]
    Gpt4120250414,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14")]
    Gpt41Mini20250414,

    [EnumMember(Value = "gpt-4.1-nano-2025-04-14")]
    Gpt41Nano20250414,

    [EnumMember(Value = "gpt-4o-2024-11-20")]
    Gpt4O20241120,

    [EnumMember(Value = "gpt-4o-2024-08-06")]
    Gpt4O20240806,

    [EnumMember(Value = "gpt-4o-2024-05-13")]
    Gpt4O20240513,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18")]
    Gpt4OMini20240718,

    [EnumMember(Value = "gpt-4-turbo-2024-04-09")]
    Gpt4Turbo20240409,

    [EnumMember(Value = "gpt-4-0125-preview")]
    Gpt40125Preview,

    [EnumMember(Value = "gpt-4-1106-preview")]
    Gpt41106Preview,

    [EnumMember(Value = "gpt-4-0613")]
    Gpt40613,

    [EnumMember(Value = "gpt-35-turbo-0125")]
    Gpt35Turbo0125,

    [EnumMember(Value = "gpt-35-turbo-1106")]
    Gpt35Turbo1106,
}

internal class UpdateAzureOpenAiCredentialDtoModelsItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAzureOpenAiCredentialDtoModelsItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAzureOpenAiCredentialDtoModelsItem
    > _stringToEnum = new()
    {
        { "gpt-5.4", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt54 },
        { "gpt-5.4-mini", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt54Mini },
        { "gpt-5.4-nano", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt54Nano },
        { "gpt-5.2", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt52 },
        { "gpt-5.2-chat", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt52Chat },
        { "gpt-5.1", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt51 },
        { "gpt-5.1-chat", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt51Chat },
        { "gpt-5", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt5 },
        { "gpt-5-mini", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt5Mini },
        { "gpt-5-nano", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt5Nano },
        { "gpt-4.1-2025-04-14", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4120250414 },
        { "gpt-4.1-mini-2025-04-14", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt41Mini20250414 },
        { "gpt-4.1-nano-2025-04-14", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt41Nano20250414 },
        { "gpt-4o-2024-11-20", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4O20241120 },
        { "gpt-4o-2024-08-06", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240806 },
        { "gpt-4o-2024-05-13", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240513 },
        { "gpt-4o-mini-2024-07-18", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4OMini20240718 },
        { "gpt-4-turbo-2024-04-09", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4Turbo20240409 },
        { "gpt-4-0125-preview", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt40125Preview },
        { "gpt-4-1106-preview", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt41106Preview },
        { "gpt-4-0613", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt40613 },
        { "gpt-35-turbo-0125", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo0125 },
        { "gpt-35-turbo-1106", UpdateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo1106 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAzureOpenAiCredentialDtoModelsItem,
        string
    > _enumToString = new()
    {
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt54, "gpt-5.4" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt54Mini, "gpt-5.4-mini" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt54Nano, "gpt-5.4-nano" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt52, "gpt-5.2" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt52Chat, "gpt-5.2-chat" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt51, "gpt-5.1" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt51Chat, "gpt-5.1-chat" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt5, "gpt-5" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt5Mini, "gpt-5-mini" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt5Nano, "gpt-5-nano" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4120250414, "gpt-4.1-2025-04-14" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt41Mini20250414, "gpt-4.1-mini-2025-04-14" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt41Nano20250414, "gpt-4.1-nano-2025-04-14" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4O20241120, "gpt-4o-2024-11-20" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240806, "gpt-4o-2024-08-06" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240513, "gpt-4o-2024-05-13" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4OMini20240718, "gpt-4o-mini-2024-07-18" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt4Turbo20240409, "gpt-4-turbo-2024-04-09" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt40125Preview, "gpt-4-0125-preview" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt41106Preview, "gpt-4-1106-preview" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt40613, "gpt-4-0613" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo0125, "gpt-35-turbo-0125" },
        { UpdateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo1106, "gpt-35-turbo-1106" },
    };

    public override UpdateAzureOpenAiCredentialDtoModelsItem Read(
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
        UpdateAzureOpenAiCredentialDtoModelsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAzureOpenAiCredentialDtoModelsItem ReadAsPropertyName(
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
        UpdateAzureOpenAiCredentialDtoModelsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
