using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureOpenAiDeploymentModelSerializer))]
public enum AzureOpenAiDeploymentModel
{
    [EnumMember(Value = "gpt-6-luna")]
    Gpt6Luna,

    [EnumMember(Value = "gpt-6-luna-2026-09-22")]
    Gpt6Luna20260922,

    [EnumMember(Value = "gpt-5.6-luna-2026-07-09")]
    Gpt56Luna20260709,

    [EnumMember(Value = "gpt-5.6-terra-2026-07-09")]
    Gpt56Terra20260709,

    [EnumMember(Value = "gpt-5.6-sol-2026-07-09")]
    Gpt56Sol20260709,

    [EnumMember(Value = "gpt-5.5")]
    Gpt55,

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

    [EnumMember(Value = "gpt-4o")]
    Gpt4O,

    [EnumMember(Value = "gpt-4.1")]
    Gpt41,

    [EnumMember(Value = "gpt-5.4-mini-2026-03-17")]
    Gpt54Mini20260317,
}

internal class AzureOpenAiDeploymentModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureOpenAiDeploymentModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureOpenAiDeploymentModel
    > _stringToEnum = new()
    {
        { "gpt-6-luna", AzureOpenAiDeploymentModel.Gpt6Luna },
        { "gpt-6-luna-2026-09-22", AzureOpenAiDeploymentModel.Gpt6Luna20260922 },
        { "gpt-5.6-luna-2026-07-09", AzureOpenAiDeploymentModel.Gpt56Luna20260709 },
        { "gpt-5.6-terra-2026-07-09", AzureOpenAiDeploymentModel.Gpt56Terra20260709 },
        { "gpt-5.6-sol-2026-07-09", AzureOpenAiDeploymentModel.Gpt56Sol20260709 },
        { "gpt-5.5", AzureOpenAiDeploymentModel.Gpt55 },
        { "gpt-5.4", AzureOpenAiDeploymentModel.Gpt54 },
        { "gpt-5.4-mini", AzureOpenAiDeploymentModel.Gpt54Mini },
        { "gpt-5.4-nano", AzureOpenAiDeploymentModel.Gpt54Nano },
        { "gpt-5.2", AzureOpenAiDeploymentModel.Gpt52 },
        { "gpt-5.2-chat", AzureOpenAiDeploymentModel.Gpt52Chat },
        { "gpt-5.1", AzureOpenAiDeploymentModel.Gpt51 },
        { "gpt-5.1-chat", AzureOpenAiDeploymentModel.Gpt51Chat },
        { "gpt-5", AzureOpenAiDeploymentModel.Gpt5 },
        { "gpt-5-mini", AzureOpenAiDeploymentModel.Gpt5Mini },
        { "gpt-5-nano", AzureOpenAiDeploymentModel.Gpt5Nano },
        { "gpt-4.1-2025-04-14", AzureOpenAiDeploymentModel.Gpt4120250414 },
        { "gpt-4.1-mini-2025-04-14", AzureOpenAiDeploymentModel.Gpt41Mini20250414 },
        { "gpt-4.1-nano-2025-04-14", AzureOpenAiDeploymentModel.Gpt41Nano20250414 },
        { "gpt-4o-2024-11-20", AzureOpenAiDeploymentModel.Gpt4O20241120 },
        { "gpt-4o-2024-08-06", AzureOpenAiDeploymentModel.Gpt4O20240806 },
        { "gpt-4o-2024-05-13", AzureOpenAiDeploymentModel.Gpt4O20240513 },
        { "gpt-4o-mini-2024-07-18", AzureOpenAiDeploymentModel.Gpt4OMini20240718 },
        { "gpt-4-turbo-2024-04-09", AzureOpenAiDeploymentModel.Gpt4Turbo20240409 },
        { "gpt-4-0125-preview", AzureOpenAiDeploymentModel.Gpt40125Preview },
        { "gpt-4-1106-preview", AzureOpenAiDeploymentModel.Gpt41106Preview },
        { "gpt-4-0613", AzureOpenAiDeploymentModel.Gpt40613 },
        { "gpt-35-turbo-0125", AzureOpenAiDeploymentModel.Gpt35Turbo0125 },
        { "gpt-35-turbo-1106", AzureOpenAiDeploymentModel.Gpt35Turbo1106 },
        { "gpt-4o", AzureOpenAiDeploymentModel.Gpt4O },
        { "gpt-4.1", AzureOpenAiDeploymentModel.Gpt41 },
        { "gpt-5.4-mini-2026-03-17", AzureOpenAiDeploymentModel.Gpt54Mini20260317 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureOpenAiDeploymentModel,
        string
    > _enumToString = new()
    {
        { AzureOpenAiDeploymentModel.Gpt6Luna, "gpt-6-luna" },
        { AzureOpenAiDeploymentModel.Gpt6Luna20260922, "gpt-6-luna-2026-09-22" },
        { AzureOpenAiDeploymentModel.Gpt56Luna20260709, "gpt-5.6-luna-2026-07-09" },
        { AzureOpenAiDeploymentModel.Gpt56Terra20260709, "gpt-5.6-terra-2026-07-09" },
        { AzureOpenAiDeploymentModel.Gpt56Sol20260709, "gpt-5.6-sol-2026-07-09" },
        { AzureOpenAiDeploymentModel.Gpt55, "gpt-5.5" },
        { AzureOpenAiDeploymentModel.Gpt54, "gpt-5.4" },
        { AzureOpenAiDeploymentModel.Gpt54Mini, "gpt-5.4-mini" },
        { AzureOpenAiDeploymentModel.Gpt54Nano, "gpt-5.4-nano" },
        { AzureOpenAiDeploymentModel.Gpt52, "gpt-5.2" },
        { AzureOpenAiDeploymentModel.Gpt52Chat, "gpt-5.2-chat" },
        { AzureOpenAiDeploymentModel.Gpt51, "gpt-5.1" },
        { AzureOpenAiDeploymentModel.Gpt51Chat, "gpt-5.1-chat" },
        { AzureOpenAiDeploymentModel.Gpt5, "gpt-5" },
        { AzureOpenAiDeploymentModel.Gpt5Mini, "gpt-5-mini" },
        { AzureOpenAiDeploymentModel.Gpt5Nano, "gpt-5-nano" },
        { AzureOpenAiDeploymentModel.Gpt4120250414, "gpt-4.1-2025-04-14" },
        { AzureOpenAiDeploymentModel.Gpt41Mini20250414, "gpt-4.1-mini-2025-04-14" },
        { AzureOpenAiDeploymentModel.Gpt41Nano20250414, "gpt-4.1-nano-2025-04-14" },
        { AzureOpenAiDeploymentModel.Gpt4O20241120, "gpt-4o-2024-11-20" },
        { AzureOpenAiDeploymentModel.Gpt4O20240806, "gpt-4o-2024-08-06" },
        { AzureOpenAiDeploymentModel.Gpt4O20240513, "gpt-4o-2024-05-13" },
        { AzureOpenAiDeploymentModel.Gpt4OMini20240718, "gpt-4o-mini-2024-07-18" },
        { AzureOpenAiDeploymentModel.Gpt4Turbo20240409, "gpt-4-turbo-2024-04-09" },
        { AzureOpenAiDeploymentModel.Gpt40125Preview, "gpt-4-0125-preview" },
        { AzureOpenAiDeploymentModel.Gpt41106Preview, "gpt-4-1106-preview" },
        { AzureOpenAiDeploymentModel.Gpt40613, "gpt-4-0613" },
        { AzureOpenAiDeploymentModel.Gpt35Turbo0125, "gpt-35-turbo-0125" },
        { AzureOpenAiDeploymentModel.Gpt35Turbo1106, "gpt-35-turbo-1106" },
        { AzureOpenAiDeploymentModel.Gpt4O, "gpt-4o" },
        { AzureOpenAiDeploymentModel.Gpt41, "gpt-4.1" },
        { AzureOpenAiDeploymentModel.Gpt54Mini20260317, "gpt-5.4-mini-2026-03-17" },
    };

    public override AzureOpenAiDeploymentModel Read(
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
        AzureOpenAiDeploymentModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureOpenAiDeploymentModel ReadAsPropertyName(
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
        AzureOpenAiDeploymentModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
