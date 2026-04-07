using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAzureOpenAiCredentialDtoModelsItemSerializer))]
public enum CreateAzureOpenAiCredentialDtoModelsItem
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

internal class CreateAzureOpenAiCredentialDtoModelsItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAzureOpenAiCredentialDtoModelsItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAzureOpenAiCredentialDtoModelsItem
    > _stringToEnum = new()
    {
        { "gpt-5.4", CreateAzureOpenAiCredentialDtoModelsItem.Gpt54 },
        { "gpt-5.4-mini", CreateAzureOpenAiCredentialDtoModelsItem.Gpt54Mini },
        { "gpt-5.4-nano", CreateAzureOpenAiCredentialDtoModelsItem.Gpt54Nano },
        { "gpt-5.2", CreateAzureOpenAiCredentialDtoModelsItem.Gpt52 },
        { "gpt-5.2-chat", CreateAzureOpenAiCredentialDtoModelsItem.Gpt52Chat },
        { "gpt-5.1", CreateAzureOpenAiCredentialDtoModelsItem.Gpt51 },
        { "gpt-5.1-chat", CreateAzureOpenAiCredentialDtoModelsItem.Gpt51Chat },
        { "gpt-5", CreateAzureOpenAiCredentialDtoModelsItem.Gpt5 },
        { "gpt-5-mini", CreateAzureOpenAiCredentialDtoModelsItem.Gpt5Mini },
        { "gpt-5-nano", CreateAzureOpenAiCredentialDtoModelsItem.Gpt5Nano },
        { "gpt-4.1-2025-04-14", CreateAzureOpenAiCredentialDtoModelsItem.Gpt4120250414 },
        { "gpt-4.1-mini-2025-04-14", CreateAzureOpenAiCredentialDtoModelsItem.Gpt41Mini20250414 },
        { "gpt-4.1-nano-2025-04-14", CreateAzureOpenAiCredentialDtoModelsItem.Gpt41Nano20250414 },
        { "gpt-4o-2024-11-20", CreateAzureOpenAiCredentialDtoModelsItem.Gpt4O20241120 },
        { "gpt-4o-2024-08-06", CreateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240806 },
        { "gpt-4o-2024-05-13", CreateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240513 },
        { "gpt-4o-mini-2024-07-18", CreateAzureOpenAiCredentialDtoModelsItem.Gpt4OMini20240718 },
        { "gpt-4-turbo-2024-04-09", CreateAzureOpenAiCredentialDtoModelsItem.Gpt4Turbo20240409 },
        { "gpt-4-0125-preview", CreateAzureOpenAiCredentialDtoModelsItem.Gpt40125Preview },
        { "gpt-4-1106-preview", CreateAzureOpenAiCredentialDtoModelsItem.Gpt41106Preview },
        { "gpt-4-0613", CreateAzureOpenAiCredentialDtoModelsItem.Gpt40613 },
        { "gpt-35-turbo-0125", CreateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo0125 },
        { "gpt-35-turbo-1106", CreateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo1106 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAzureOpenAiCredentialDtoModelsItem,
        string
    > _enumToString = new()
    {
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt54, "gpt-5.4" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt54Mini, "gpt-5.4-mini" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt54Nano, "gpt-5.4-nano" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt52, "gpt-5.2" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt52Chat, "gpt-5.2-chat" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt51, "gpt-5.1" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt51Chat, "gpt-5.1-chat" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt5, "gpt-5" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt5Mini, "gpt-5-mini" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt5Nano, "gpt-5-nano" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt4120250414, "gpt-4.1-2025-04-14" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt41Mini20250414, "gpt-4.1-mini-2025-04-14" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt41Nano20250414, "gpt-4.1-nano-2025-04-14" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt4O20241120, "gpt-4o-2024-11-20" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240806, "gpt-4o-2024-08-06" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt4O20240513, "gpt-4o-2024-05-13" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt4OMini20240718, "gpt-4o-mini-2024-07-18" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt4Turbo20240409, "gpt-4-turbo-2024-04-09" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt40125Preview, "gpt-4-0125-preview" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt41106Preview, "gpt-4-1106-preview" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt40613, "gpt-4-0613" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo0125, "gpt-35-turbo-0125" },
        { CreateAzureOpenAiCredentialDtoModelsItem.Gpt35Turbo1106, "gpt-35-turbo-1106" },
    };

    public override CreateAzureOpenAiCredentialDtoModelsItem Read(
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
        CreateAzureOpenAiCredentialDtoModelsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAzureOpenAiCredentialDtoModelsItem ReadAsPropertyName(
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
        CreateAzureOpenAiCredentialDtoModelsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
