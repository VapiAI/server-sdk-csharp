using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiModelFallbackModelsItemSerializer))]
public enum OpenAiModelFallbackModelsItem
{
    [EnumMember(Value = "gpt-5.4")]
    Gpt54,

    [EnumMember(Value = "gpt-5.4-mini")]
    Gpt54Mini,

    [EnumMember(Value = "gpt-5.4-nano")]
    Gpt54Nano,

    [EnumMember(Value = "gpt-5.2")]
    Gpt52,

    [EnumMember(Value = "gpt-5.2-chat-latest")]
    Gpt52ChatLatest,

    [EnumMember(Value = "gpt-5.1")]
    Gpt51,

    [EnumMember(Value = "gpt-5.1-chat-latest")]
    Gpt51ChatLatest,

    [EnumMember(Value = "gpt-5")]
    Gpt5,

    [EnumMember(Value = "gpt-5-chat-latest")]
    Gpt5ChatLatest,

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

    [EnumMember(Value = "gpt-4.1")]
    Gpt41,

    [EnumMember(Value = "gpt-4.1-mini")]
    Gpt41Mini,

    [EnumMember(Value = "gpt-4.1-nano")]
    Gpt41Nano,

    [EnumMember(Value = "chatgpt-4o-latest")]
    Chatgpt4OLatest,

    [EnumMember(Value = "o3")]
    O3,

    [EnumMember(Value = "o3-mini")]
    O3Mini,

    [EnumMember(Value = "o4-mini")]
    O4Mini,

    [EnumMember(Value = "o1-mini")]
    O1Mini,

    [EnumMember(Value = "o1-mini-2024-09-12")]
    O1Mini20240912,

    [EnumMember(Value = "gpt-4o-realtime-preview-2024-10-01")]
    Gpt4ORealtimePreview20241001,

    [EnumMember(Value = "gpt-4o-realtime-preview-2024-12-17")]
    Gpt4ORealtimePreview20241217,

    [EnumMember(Value = "gpt-4o-mini-realtime-preview-2024-12-17")]
    Gpt4OMiniRealtimePreview20241217,

    [EnumMember(Value = "gpt-realtime-2025-08-28")]
    GptRealtime20250828,

    [EnumMember(Value = "gpt-realtime-mini-2025-12-15")]
    GptRealtimeMini20251215,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18")]
    Gpt4OMini20240718,

    [EnumMember(Value = "gpt-4o-mini")]
    Gpt4OMini,

    [EnumMember(Value = "gpt-4o")]
    Gpt4O,

    [EnumMember(Value = "gpt-4o-2024-05-13")]
    Gpt4O20240513,

    [EnumMember(Value = "gpt-4o-2024-08-06")]
    Gpt4O20240806,

    [EnumMember(Value = "gpt-4o-2024-11-20")]
    Gpt4O20241120,

    [EnumMember(Value = "gpt-4-turbo")]
    Gpt4Turbo,

    [EnumMember(Value = "gpt-4-turbo-2024-04-09")]
    Gpt4Turbo20240409,

    [EnumMember(Value = "gpt-4-turbo-preview")]
    Gpt4TurboPreview,

    [EnumMember(Value = "gpt-4-0125-preview")]
    Gpt40125Preview,

    [EnumMember(Value = "gpt-4-1106-preview")]
    Gpt41106Preview,

    [EnumMember(Value = "gpt-4")]
    Gpt4,

    [EnumMember(Value = "gpt-4-0613")]
    Gpt40613,

    [EnumMember(Value = "gpt-3.5-turbo")]
    Gpt35Turbo,

    [EnumMember(Value = "gpt-3.5-turbo-0125")]
    Gpt35Turbo0125,

    [EnumMember(Value = "gpt-3.5-turbo-1106")]
    Gpt35Turbo1106,

    [EnumMember(Value = "gpt-3.5-turbo-16k")]
    Gpt35Turbo16K,

    [EnumMember(Value = "gpt-3.5-turbo-0613")]
    Gpt35Turbo0613,

    [EnumMember(Value = "gpt-4.1-2025-04-14:westus")]
    Gpt4120250414Westus,

    [EnumMember(Value = "gpt-4.1-2025-04-14:eastus2")]
    Gpt4120250414Eastus2,

    [EnumMember(Value = "gpt-4.1-2025-04-14:eastus")]
    Gpt4120250414Eastus,

    [EnumMember(Value = "gpt-4.1-2025-04-14:westus3")]
    Gpt4120250414Westus3,

    [EnumMember(Value = "gpt-4.1-2025-04-14:northcentralus")]
    Gpt4120250414Northcentralus,

    [EnumMember(Value = "gpt-4.1-2025-04-14:southcentralus")]
    Gpt4120250414Southcentralus,

    [EnumMember(Value = "gpt-4.1-2025-04-14:westeurope")]
    Gpt4120250414Westeurope,

    [EnumMember(Value = "gpt-4.1-2025-04-14:germanywestcentral")]
    Gpt4120250414Germanywestcentral,

    [EnumMember(Value = "gpt-4.1-2025-04-14:polandcentral")]
    Gpt4120250414Polandcentral,

    [EnumMember(Value = "gpt-4.1-2025-04-14:spaincentral")]
    Gpt4120250414Spaincentral,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:westus")]
    Gpt41Mini20250414Westus,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:eastus2")]
    Gpt41Mini20250414Eastus2,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:eastus")]
    Gpt41Mini20250414Eastus,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:westus3")]
    Gpt41Mini20250414Westus3,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:northcentralus")]
    Gpt41Mini20250414Northcentralus,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:southcentralus")]
    Gpt41Mini20250414Southcentralus,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:westeurope")]
    Gpt41Mini20250414Westeurope,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:germanywestcentral")]
    Gpt41Mini20250414Germanywestcentral,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:polandcentral")]
    Gpt41Mini20250414Polandcentral,

    [EnumMember(Value = "gpt-4.1-mini-2025-04-14:spaincentral")]
    Gpt41Mini20250414Spaincentral,

    [EnumMember(Value = "gpt-4.1-nano-2025-04-14:westus")]
    Gpt41Nano20250414Westus,

    [EnumMember(Value = "gpt-4.1-nano-2025-04-14:eastus2")]
    Gpt41Nano20250414Eastus2,

    [EnumMember(Value = "gpt-4.1-nano-2025-04-14:westus3")]
    Gpt41Nano20250414Westus3,

    [EnumMember(Value = "gpt-4.1-nano-2025-04-14:northcentralus")]
    Gpt41Nano20250414Northcentralus,

    [EnumMember(Value = "gpt-4.1-nano-2025-04-14:southcentralus")]
    Gpt41Nano20250414Southcentralus,

    [EnumMember(Value = "gpt-4o-2024-11-20:swedencentral")]
    Gpt4O20241120Swedencentral,

    [EnumMember(Value = "gpt-4o-2024-11-20:westus")]
    Gpt4O20241120Westus,

    [EnumMember(Value = "gpt-4o-2024-11-20:eastus2")]
    Gpt4O20241120Eastus2,

    [EnumMember(Value = "gpt-4o-2024-11-20:eastus")]
    Gpt4O20241120Eastus,

    [EnumMember(Value = "gpt-4o-2024-11-20:westus3")]
    Gpt4O20241120Westus3,

    [EnumMember(Value = "gpt-4o-2024-11-20:southcentralus")]
    Gpt4O20241120Southcentralus,

    [EnumMember(Value = "gpt-4o-2024-11-20:westeurope")]
    Gpt4O20241120Westeurope,

    [EnumMember(Value = "gpt-4o-2024-11-20:germanywestcentral")]
    Gpt4O20241120Germanywestcentral,

    [EnumMember(Value = "gpt-4o-2024-11-20:polandcentral")]
    Gpt4O20241120Polandcentral,

    [EnumMember(Value = "gpt-4o-2024-11-20:spaincentral")]
    Gpt4O20241120Spaincentral,

    [EnumMember(Value = "gpt-4o-2024-08-06:westus")]
    Gpt4O20240806Westus,

    [EnumMember(Value = "gpt-4o-2024-08-06:westus3")]
    Gpt4O20240806Westus3,

    [EnumMember(Value = "gpt-4o-2024-08-06:eastus")]
    Gpt4O20240806Eastus,

    [EnumMember(Value = "gpt-4o-2024-08-06:eastus2")]
    Gpt4O20240806Eastus2,

    [EnumMember(Value = "gpt-4o-2024-08-06:northcentralus")]
    Gpt4O20240806Northcentralus,

    [EnumMember(Value = "gpt-4o-2024-08-06:southcentralus")]
    Gpt4O20240806Southcentralus,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18:westus")]
    Gpt4OMini20240718Westus,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18:westus3")]
    Gpt4OMini20240718Westus3,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18:eastus")]
    Gpt4OMini20240718Eastus,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18:eastus2")]
    Gpt4OMini20240718Eastus2,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18:northcentralus")]
    Gpt4OMini20240718Northcentralus,

    [EnumMember(Value = "gpt-4o-mini-2024-07-18:southcentralus")]
    Gpt4OMini20240718Southcentralus,

    [EnumMember(Value = "gpt-4o-2024-05-13:eastus2")]
    Gpt4O20240513Eastus2,

    [EnumMember(Value = "gpt-4o-2024-05-13:eastus")]
    Gpt4O20240513Eastus,

    [EnumMember(Value = "gpt-4o-2024-05-13:northcentralus")]
    Gpt4O20240513Northcentralus,

    [EnumMember(Value = "gpt-4o-2024-05-13:southcentralus")]
    Gpt4O20240513Southcentralus,

    [EnumMember(Value = "gpt-4o-2024-05-13:westus3")]
    Gpt4O20240513Westus3,

    [EnumMember(Value = "gpt-4o-2024-05-13:westus")]
    Gpt4O20240513Westus,

    [EnumMember(Value = "gpt-4-turbo-2024-04-09:eastus2")]
    Gpt4Turbo20240409Eastus2,

    [EnumMember(Value = "gpt-4-0125-preview:eastus")]
    Gpt40125PreviewEastus,

    [EnumMember(Value = "gpt-4-0125-preview:northcentralus")]
    Gpt40125PreviewNorthcentralus,

    [EnumMember(Value = "gpt-4-0125-preview:southcentralus")]
    Gpt40125PreviewSouthcentralus,

    [EnumMember(Value = "gpt-4-1106-preview:australiaeast")]
    Gpt41106PreviewAustraliaeast,

    [EnumMember(Value = "gpt-4-1106-preview:canadaeast")]
    Gpt41106PreviewCanadaeast,

    [EnumMember(Value = "gpt-4-1106-preview:france")]
    Gpt41106PreviewFrance,

    [EnumMember(Value = "gpt-4-1106-preview:india")]
    Gpt41106PreviewIndia,

    [EnumMember(Value = "gpt-4-1106-preview:norway")]
    Gpt41106PreviewNorway,

    [EnumMember(Value = "gpt-4-1106-preview:swedencentral")]
    Gpt41106PreviewSwedencentral,

    [EnumMember(Value = "gpt-4-1106-preview:uk")]
    Gpt41106PreviewUk,

    [EnumMember(Value = "gpt-4-1106-preview:westus")]
    Gpt41106PreviewWestus,

    [EnumMember(Value = "gpt-4-1106-preview:westus3")]
    Gpt41106PreviewWestus3,

    [EnumMember(Value = "gpt-4-0613:canadaeast")]
    Gpt40613Canadaeast,

    [EnumMember(Value = "gpt-3.5-turbo-0125:canadaeast")]
    Gpt35Turbo0125Canadaeast,

    [EnumMember(Value = "gpt-3.5-turbo-0125:northcentralus")]
    Gpt35Turbo0125Northcentralus,

    [EnumMember(Value = "gpt-3.5-turbo-0125:southcentralus")]
    Gpt35Turbo0125Southcentralus,

    [EnumMember(Value = "gpt-3.5-turbo-1106:canadaeast")]
    Gpt35Turbo1106Canadaeast,

    [EnumMember(Value = "gpt-3.5-turbo-1106:westus")]
    Gpt35Turbo1106Westus,
}

internal class OpenAiModelFallbackModelsItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiModelFallbackModelsItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiModelFallbackModelsItem
    > _stringToEnum = new()
    {
        { "gpt-5.4", OpenAiModelFallbackModelsItem.Gpt54 },
        { "gpt-5.4-mini", OpenAiModelFallbackModelsItem.Gpt54Mini },
        { "gpt-5.4-nano", OpenAiModelFallbackModelsItem.Gpt54Nano },
        { "gpt-5.2", OpenAiModelFallbackModelsItem.Gpt52 },
        { "gpt-5.2-chat-latest", OpenAiModelFallbackModelsItem.Gpt52ChatLatest },
        { "gpt-5.1", OpenAiModelFallbackModelsItem.Gpt51 },
        { "gpt-5.1-chat-latest", OpenAiModelFallbackModelsItem.Gpt51ChatLatest },
        { "gpt-5", OpenAiModelFallbackModelsItem.Gpt5 },
        { "gpt-5-chat-latest", OpenAiModelFallbackModelsItem.Gpt5ChatLatest },
        { "gpt-5-mini", OpenAiModelFallbackModelsItem.Gpt5Mini },
        { "gpt-5-nano", OpenAiModelFallbackModelsItem.Gpt5Nano },
        { "gpt-4.1-2025-04-14", OpenAiModelFallbackModelsItem.Gpt4120250414 },
        { "gpt-4.1-mini-2025-04-14", OpenAiModelFallbackModelsItem.Gpt41Mini20250414 },
        { "gpt-4.1-nano-2025-04-14", OpenAiModelFallbackModelsItem.Gpt41Nano20250414 },
        { "gpt-4.1", OpenAiModelFallbackModelsItem.Gpt41 },
        { "gpt-4.1-mini", OpenAiModelFallbackModelsItem.Gpt41Mini },
        { "gpt-4.1-nano", OpenAiModelFallbackModelsItem.Gpt41Nano },
        { "chatgpt-4o-latest", OpenAiModelFallbackModelsItem.Chatgpt4OLatest },
        { "o3", OpenAiModelFallbackModelsItem.O3 },
        { "o3-mini", OpenAiModelFallbackModelsItem.O3Mini },
        { "o4-mini", OpenAiModelFallbackModelsItem.O4Mini },
        { "o1-mini", OpenAiModelFallbackModelsItem.O1Mini },
        { "o1-mini-2024-09-12", OpenAiModelFallbackModelsItem.O1Mini20240912 },
        {
            "gpt-4o-realtime-preview-2024-10-01",
            OpenAiModelFallbackModelsItem.Gpt4ORealtimePreview20241001
        },
        {
            "gpt-4o-realtime-preview-2024-12-17",
            OpenAiModelFallbackModelsItem.Gpt4ORealtimePreview20241217
        },
        {
            "gpt-4o-mini-realtime-preview-2024-12-17",
            OpenAiModelFallbackModelsItem.Gpt4OMiniRealtimePreview20241217
        },
        { "gpt-realtime-2025-08-28", OpenAiModelFallbackModelsItem.GptRealtime20250828 },
        { "gpt-realtime-mini-2025-12-15", OpenAiModelFallbackModelsItem.GptRealtimeMini20251215 },
        { "gpt-4o-mini-2024-07-18", OpenAiModelFallbackModelsItem.Gpt4OMini20240718 },
        { "gpt-4o-mini", OpenAiModelFallbackModelsItem.Gpt4OMini },
        { "gpt-4o", OpenAiModelFallbackModelsItem.Gpt4O },
        { "gpt-4o-2024-05-13", OpenAiModelFallbackModelsItem.Gpt4O20240513 },
        { "gpt-4o-2024-08-06", OpenAiModelFallbackModelsItem.Gpt4O20240806 },
        { "gpt-4o-2024-11-20", OpenAiModelFallbackModelsItem.Gpt4O20241120 },
        { "gpt-4-turbo", OpenAiModelFallbackModelsItem.Gpt4Turbo },
        { "gpt-4-turbo-2024-04-09", OpenAiModelFallbackModelsItem.Gpt4Turbo20240409 },
        { "gpt-4-turbo-preview", OpenAiModelFallbackModelsItem.Gpt4TurboPreview },
        { "gpt-4-0125-preview", OpenAiModelFallbackModelsItem.Gpt40125Preview },
        { "gpt-4-1106-preview", OpenAiModelFallbackModelsItem.Gpt41106Preview },
        { "gpt-4", OpenAiModelFallbackModelsItem.Gpt4 },
        { "gpt-4-0613", OpenAiModelFallbackModelsItem.Gpt40613 },
        { "gpt-3.5-turbo", OpenAiModelFallbackModelsItem.Gpt35Turbo },
        { "gpt-3.5-turbo-0125", OpenAiModelFallbackModelsItem.Gpt35Turbo0125 },
        { "gpt-3.5-turbo-1106", OpenAiModelFallbackModelsItem.Gpt35Turbo1106 },
        { "gpt-3.5-turbo-16k", OpenAiModelFallbackModelsItem.Gpt35Turbo16K },
        { "gpt-3.5-turbo-0613", OpenAiModelFallbackModelsItem.Gpt35Turbo0613 },
        { "gpt-4.1-2025-04-14:westus", OpenAiModelFallbackModelsItem.Gpt4120250414Westus },
        { "gpt-4.1-2025-04-14:eastus2", OpenAiModelFallbackModelsItem.Gpt4120250414Eastus2 },
        { "gpt-4.1-2025-04-14:eastus", OpenAiModelFallbackModelsItem.Gpt4120250414Eastus },
        { "gpt-4.1-2025-04-14:westus3", OpenAiModelFallbackModelsItem.Gpt4120250414Westus3 },
        {
            "gpt-4.1-2025-04-14:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt4120250414Northcentralus
        },
        {
            "gpt-4.1-2025-04-14:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt4120250414Southcentralus
        },
        { "gpt-4.1-2025-04-14:westeurope", OpenAiModelFallbackModelsItem.Gpt4120250414Westeurope },
        {
            "gpt-4.1-2025-04-14:germanywestcentral",
            OpenAiModelFallbackModelsItem.Gpt4120250414Germanywestcentral
        },
        {
            "gpt-4.1-2025-04-14:polandcentral",
            OpenAiModelFallbackModelsItem.Gpt4120250414Polandcentral
        },
        {
            "gpt-4.1-2025-04-14:spaincentral",
            OpenAiModelFallbackModelsItem.Gpt4120250414Spaincentral
        },
        { "gpt-4.1-mini-2025-04-14:westus", OpenAiModelFallbackModelsItem.Gpt41Mini20250414Westus },
        {
            "gpt-4.1-mini-2025-04-14:eastus2",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Eastus2
        },
        { "gpt-4.1-mini-2025-04-14:eastus", OpenAiModelFallbackModelsItem.Gpt41Mini20250414Eastus },
        {
            "gpt-4.1-mini-2025-04-14:westus3",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Westus3
        },
        {
            "gpt-4.1-mini-2025-04-14:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Northcentralus
        },
        {
            "gpt-4.1-mini-2025-04-14:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Southcentralus
        },
        {
            "gpt-4.1-mini-2025-04-14:westeurope",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Westeurope
        },
        {
            "gpt-4.1-mini-2025-04-14:germanywestcentral",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Germanywestcentral
        },
        {
            "gpt-4.1-mini-2025-04-14:polandcentral",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Polandcentral
        },
        {
            "gpt-4.1-mini-2025-04-14:spaincentral",
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Spaincentral
        },
        { "gpt-4.1-nano-2025-04-14:westus", OpenAiModelFallbackModelsItem.Gpt41Nano20250414Westus },
        {
            "gpt-4.1-nano-2025-04-14:eastus2",
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Eastus2
        },
        {
            "gpt-4.1-nano-2025-04-14:westus3",
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Westus3
        },
        {
            "gpt-4.1-nano-2025-04-14:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Northcentralus
        },
        {
            "gpt-4.1-nano-2025-04-14:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Southcentralus
        },
        {
            "gpt-4o-2024-11-20:swedencentral",
            OpenAiModelFallbackModelsItem.Gpt4O20241120Swedencentral
        },
        { "gpt-4o-2024-11-20:westus", OpenAiModelFallbackModelsItem.Gpt4O20241120Westus },
        { "gpt-4o-2024-11-20:eastus2", OpenAiModelFallbackModelsItem.Gpt4O20241120Eastus2 },
        { "gpt-4o-2024-11-20:eastus", OpenAiModelFallbackModelsItem.Gpt4O20241120Eastus },
        { "gpt-4o-2024-11-20:westus3", OpenAiModelFallbackModelsItem.Gpt4O20241120Westus3 },
        {
            "gpt-4o-2024-11-20:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt4O20241120Southcentralus
        },
        { "gpt-4o-2024-11-20:westeurope", OpenAiModelFallbackModelsItem.Gpt4O20241120Westeurope },
        {
            "gpt-4o-2024-11-20:germanywestcentral",
            OpenAiModelFallbackModelsItem.Gpt4O20241120Germanywestcentral
        },
        {
            "gpt-4o-2024-11-20:polandcentral",
            OpenAiModelFallbackModelsItem.Gpt4O20241120Polandcentral
        },
        {
            "gpt-4o-2024-11-20:spaincentral",
            OpenAiModelFallbackModelsItem.Gpt4O20241120Spaincentral
        },
        { "gpt-4o-2024-08-06:westus", OpenAiModelFallbackModelsItem.Gpt4O20240806Westus },
        { "gpt-4o-2024-08-06:westus3", OpenAiModelFallbackModelsItem.Gpt4O20240806Westus3 },
        { "gpt-4o-2024-08-06:eastus", OpenAiModelFallbackModelsItem.Gpt4O20240806Eastus },
        { "gpt-4o-2024-08-06:eastus2", OpenAiModelFallbackModelsItem.Gpt4O20240806Eastus2 },
        {
            "gpt-4o-2024-08-06:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt4O20240806Northcentralus
        },
        {
            "gpt-4o-2024-08-06:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt4O20240806Southcentralus
        },
        { "gpt-4o-mini-2024-07-18:westus", OpenAiModelFallbackModelsItem.Gpt4OMini20240718Westus },
        {
            "gpt-4o-mini-2024-07-18:westus3",
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Westus3
        },
        { "gpt-4o-mini-2024-07-18:eastus", OpenAiModelFallbackModelsItem.Gpt4OMini20240718Eastus },
        {
            "gpt-4o-mini-2024-07-18:eastus2",
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Eastus2
        },
        {
            "gpt-4o-mini-2024-07-18:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Northcentralus
        },
        {
            "gpt-4o-mini-2024-07-18:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Southcentralus
        },
        { "gpt-4o-2024-05-13:eastus2", OpenAiModelFallbackModelsItem.Gpt4O20240513Eastus2 },
        { "gpt-4o-2024-05-13:eastus", OpenAiModelFallbackModelsItem.Gpt4O20240513Eastus },
        {
            "gpt-4o-2024-05-13:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt4O20240513Northcentralus
        },
        {
            "gpt-4o-2024-05-13:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt4O20240513Southcentralus
        },
        { "gpt-4o-2024-05-13:westus3", OpenAiModelFallbackModelsItem.Gpt4O20240513Westus3 },
        { "gpt-4o-2024-05-13:westus", OpenAiModelFallbackModelsItem.Gpt4O20240513Westus },
        {
            "gpt-4-turbo-2024-04-09:eastus2",
            OpenAiModelFallbackModelsItem.Gpt4Turbo20240409Eastus2
        },
        { "gpt-4-0125-preview:eastus", OpenAiModelFallbackModelsItem.Gpt40125PreviewEastus },
        {
            "gpt-4-0125-preview:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt40125PreviewNorthcentralus
        },
        {
            "gpt-4-0125-preview:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt40125PreviewSouthcentralus
        },
        {
            "gpt-4-1106-preview:australiaeast",
            OpenAiModelFallbackModelsItem.Gpt41106PreviewAustraliaeast
        },
        {
            "gpt-4-1106-preview:canadaeast",
            OpenAiModelFallbackModelsItem.Gpt41106PreviewCanadaeast
        },
        { "gpt-4-1106-preview:france", OpenAiModelFallbackModelsItem.Gpt41106PreviewFrance },
        { "gpt-4-1106-preview:india", OpenAiModelFallbackModelsItem.Gpt41106PreviewIndia },
        { "gpt-4-1106-preview:norway", OpenAiModelFallbackModelsItem.Gpt41106PreviewNorway },
        {
            "gpt-4-1106-preview:swedencentral",
            OpenAiModelFallbackModelsItem.Gpt41106PreviewSwedencentral
        },
        { "gpt-4-1106-preview:uk", OpenAiModelFallbackModelsItem.Gpt41106PreviewUk },
        { "gpt-4-1106-preview:westus", OpenAiModelFallbackModelsItem.Gpt41106PreviewWestus },
        { "gpt-4-1106-preview:westus3", OpenAiModelFallbackModelsItem.Gpt41106PreviewWestus3 },
        { "gpt-4-0613:canadaeast", OpenAiModelFallbackModelsItem.Gpt40613Canadaeast },
        { "gpt-3.5-turbo-0125:canadaeast", OpenAiModelFallbackModelsItem.Gpt35Turbo0125Canadaeast },
        {
            "gpt-3.5-turbo-0125:northcentralus",
            OpenAiModelFallbackModelsItem.Gpt35Turbo0125Northcentralus
        },
        {
            "gpt-3.5-turbo-0125:southcentralus",
            OpenAiModelFallbackModelsItem.Gpt35Turbo0125Southcentralus
        },
        { "gpt-3.5-turbo-1106:canadaeast", OpenAiModelFallbackModelsItem.Gpt35Turbo1106Canadaeast },
        { "gpt-3.5-turbo-1106:westus", OpenAiModelFallbackModelsItem.Gpt35Turbo1106Westus },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiModelFallbackModelsItem,
        string
    > _enumToString = new()
    {
        { OpenAiModelFallbackModelsItem.Gpt54, "gpt-5.4" },
        { OpenAiModelFallbackModelsItem.Gpt54Mini, "gpt-5.4-mini" },
        { OpenAiModelFallbackModelsItem.Gpt54Nano, "gpt-5.4-nano" },
        { OpenAiModelFallbackModelsItem.Gpt52, "gpt-5.2" },
        { OpenAiModelFallbackModelsItem.Gpt52ChatLatest, "gpt-5.2-chat-latest" },
        { OpenAiModelFallbackModelsItem.Gpt51, "gpt-5.1" },
        { OpenAiModelFallbackModelsItem.Gpt51ChatLatest, "gpt-5.1-chat-latest" },
        { OpenAiModelFallbackModelsItem.Gpt5, "gpt-5" },
        { OpenAiModelFallbackModelsItem.Gpt5ChatLatest, "gpt-5-chat-latest" },
        { OpenAiModelFallbackModelsItem.Gpt5Mini, "gpt-5-mini" },
        { OpenAiModelFallbackModelsItem.Gpt5Nano, "gpt-5-nano" },
        { OpenAiModelFallbackModelsItem.Gpt4120250414, "gpt-4.1-2025-04-14" },
        { OpenAiModelFallbackModelsItem.Gpt41Mini20250414, "gpt-4.1-mini-2025-04-14" },
        { OpenAiModelFallbackModelsItem.Gpt41Nano20250414, "gpt-4.1-nano-2025-04-14" },
        { OpenAiModelFallbackModelsItem.Gpt41, "gpt-4.1" },
        { OpenAiModelFallbackModelsItem.Gpt41Mini, "gpt-4.1-mini" },
        { OpenAiModelFallbackModelsItem.Gpt41Nano, "gpt-4.1-nano" },
        { OpenAiModelFallbackModelsItem.Chatgpt4OLatest, "chatgpt-4o-latest" },
        { OpenAiModelFallbackModelsItem.O3, "o3" },
        { OpenAiModelFallbackModelsItem.O3Mini, "o3-mini" },
        { OpenAiModelFallbackModelsItem.O4Mini, "o4-mini" },
        { OpenAiModelFallbackModelsItem.O1Mini, "o1-mini" },
        { OpenAiModelFallbackModelsItem.O1Mini20240912, "o1-mini-2024-09-12" },
        {
            OpenAiModelFallbackModelsItem.Gpt4ORealtimePreview20241001,
            "gpt-4o-realtime-preview-2024-10-01"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4ORealtimePreview20241217,
            "gpt-4o-realtime-preview-2024-12-17"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4OMiniRealtimePreview20241217,
            "gpt-4o-mini-realtime-preview-2024-12-17"
        },
        { OpenAiModelFallbackModelsItem.GptRealtime20250828, "gpt-realtime-2025-08-28" },
        { OpenAiModelFallbackModelsItem.GptRealtimeMini20251215, "gpt-realtime-mini-2025-12-15" },
        { OpenAiModelFallbackModelsItem.Gpt4OMini20240718, "gpt-4o-mini-2024-07-18" },
        { OpenAiModelFallbackModelsItem.Gpt4OMini, "gpt-4o-mini" },
        { OpenAiModelFallbackModelsItem.Gpt4O, "gpt-4o" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240513, "gpt-4o-2024-05-13" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240806, "gpt-4o-2024-08-06" },
        { OpenAiModelFallbackModelsItem.Gpt4O20241120, "gpt-4o-2024-11-20" },
        { OpenAiModelFallbackModelsItem.Gpt4Turbo, "gpt-4-turbo" },
        { OpenAiModelFallbackModelsItem.Gpt4Turbo20240409, "gpt-4-turbo-2024-04-09" },
        { OpenAiModelFallbackModelsItem.Gpt4TurboPreview, "gpt-4-turbo-preview" },
        { OpenAiModelFallbackModelsItem.Gpt40125Preview, "gpt-4-0125-preview" },
        { OpenAiModelFallbackModelsItem.Gpt41106Preview, "gpt-4-1106-preview" },
        { OpenAiModelFallbackModelsItem.Gpt4, "gpt-4" },
        { OpenAiModelFallbackModelsItem.Gpt40613, "gpt-4-0613" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo, "gpt-3.5-turbo" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo0125, "gpt-3.5-turbo-0125" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo1106, "gpt-3.5-turbo-1106" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo16K, "gpt-3.5-turbo-16k" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo0613, "gpt-3.5-turbo-0613" },
        { OpenAiModelFallbackModelsItem.Gpt4120250414Westus, "gpt-4.1-2025-04-14:westus" },
        { OpenAiModelFallbackModelsItem.Gpt4120250414Eastus2, "gpt-4.1-2025-04-14:eastus2" },
        { OpenAiModelFallbackModelsItem.Gpt4120250414Eastus, "gpt-4.1-2025-04-14:eastus" },
        { OpenAiModelFallbackModelsItem.Gpt4120250414Westus3, "gpt-4.1-2025-04-14:westus3" },
        {
            OpenAiModelFallbackModelsItem.Gpt4120250414Northcentralus,
            "gpt-4.1-2025-04-14:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4120250414Southcentralus,
            "gpt-4.1-2025-04-14:southcentralus"
        },
        { OpenAiModelFallbackModelsItem.Gpt4120250414Westeurope, "gpt-4.1-2025-04-14:westeurope" },
        {
            OpenAiModelFallbackModelsItem.Gpt4120250414Germanywestcentral,
            "gpt-4.1-2025-04-14:germanywestcentral"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4120250414Polandcentral,
            "gpt-4.1-2025-04-14:polandcentral"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4120250414Spaincentral,
            "gpt-4.1-2025-04-14:spaincentral"
        },
        { OpenAiModelFallbackModelsItem.Gpt41Mini20250414Westus, "gpt-4.1-mini-2025-04-14:westus" },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Eastus2,
            "gpt-4.1-mini-2025-04-14:eastus2"
        },
        { OpenAiModelFallbackModelsItem.Gpt41Mini20250414Eastus, "gpt-4.1-mini-2025-04-14:eastus" },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Westus3,
            "gpt-4.1-mini-2025-04-14:westus3"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Northcentralus,
            "gpt-4.1-mini-2025-04-14:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Southcentralus,
            "gpt-4.1-mini-2025-04-14:southcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Westeurope,
            "gpt-4.1-mini-2025-04-14:westeurope"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Germanywestcentral,
            "gpt-4.1-mini-2025-04-14:germanywestcentral"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Polandcentral,
            "gpt-4.1-mini-2025-04-14:polandcentral"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Mini20250414Spaincentral,
            "gpt-4.1-mini-2025-04-14:spaincentral"
        },
        { OpenAiModelFallbackModelsItem.Gpt41Nano20250414Westus, "gpt-4.1-nano-2025-04-14:westus" },
        {
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Eastus2,
            "gpt-4.1-nano-2025-04-14:eastus2"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Westus3,
            "gpt-4.1-nano-2025-04-14:westus3"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Northcentralus,
            "gpt-4.1-nano-2025-04-14:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41Nano20250414Southcentralus,
            "gpt-4.1-nano-2025-04-14:southcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20241120Swedencentral,
            "gpt-4o-2024-11-20:swedencentral"
        },
        { OpenAiModelFallbackModelsItem.Gpt4O20241120Westus, "gpt-4o-2024-11-20:westus" },
        { OpenAiModelFallbackModelsItem.Gpt4O20241120Eastus2, "gpt-4o-2024-11-20:eastus2" },
        { OpenAiModelFallbackModelsItem.Gpt4O20241120Eastus, "gpt-4o-2024-11-20:eastus" },
        { OpenAiModelFallbackModelsItem.Gpt4O20241120Westus3, "gpt-4o-2024-11-20:westus3" },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20241120Southcentralus,
            "gpt-4o-2024-11-20:southcentralus"
        },
        { OpenAiModelFallbackModelsItem.Gpt4O20241120Westeurope, "gpt-4o-2024-11-20:westeurope" },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20241120Germanywestcentral,
            "gpt-4o-2024-11-20:germanywestcentral"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20241120Polandcentral,
            "gpt-4o-2024-11-20:polandcentral"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20241120Spaincentral,
            "gpt-4o-2024-11-20:spaincentral"
        },
        { OpenAiModelFallbackModelsItem.Gpt4O20240806Westus, "gpt-4o-2024-08-06:westus" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240806Westus3, "gpt-4o-2024-08-06:westus3" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240806Eastus, "gpt-4o-2024-08-06:eastus" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240806Eastus2, "gpt-4o-2024-08-06:eastus2" },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20240806Northcentralus,
            "gpt-4o-2024-08-06:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20240806Southcentralus,
            "gpt-4o-2024-08-06:southcentralus"
        },
        { OpenAiModelFallbackModelsItem.Gpt4OMini20240718Westus, "gpt-4o-mini-2024-07-18:westus" },
        {
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Westus3,
            "gpt-4o-mini-2024-07-18:westus3"
        },
        { OpenAiModelFallbackModelsItem.Gpt4OMini20240718Eastus, "gpt-4o-mini-2024-07-18:eastus" },
        {
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Eastus2,
            "gpt-4o-mini-2024-07-18:eastus2"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Northcentralus,
            "gpt-4o-mini-2024-07-18:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4OMini20240718Southcentralus,
            "gpt-4o-mini-2024-07-18:southcentralus"
        },
        { OpenAiModelFallbackModelsItem.Gpt4O20240513Eastus2, "gpt-4o-2024-05-13:eastus2" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240513Eastus, "gpt-4o-2024-05-13:eastus" },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20240513Northcentralus,
            "gpt-4o-2024-05-13:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt4O20240513Southcentralus,
            "gpt-4o-2024-05-13:southcentralus"
        },
        { OpenAiModelFallbackModelsItem.Gpt4O20240513Westus3, "gpt-4o-2024-05-13:westus3" },
        { OpenAiModelFallbackModelsItem.Gpt4O20240513Westus, "gpt-4o-2024-05-13:westus" },
        {
            OpenAiModelFallbackModelsItem.Gpt4Turbo20240409Eastus2,
            "gpt-4-turbo-2024-04-09:eastus2"
        },
        { OpenAiModelFallbackModelsItem.Gpt40125PreviewEastus, "gpt-4-0125-preview:eastus" },
        {
            OpenAiModelFallbackModelsItem.Gpt40125PreviewNorthcentralus,
            "gpt-4-0125-preview:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt40125PreviewSouthcentralus,
            "gpt-4-0125-preview:southcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41106PreviewAustraliaeast,
            "gpt-4-1106-preview:australiaeast"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt41106PreviewCanadaeast,
            "gpt-4-1106-preview:canadaeast"
        },
        { OpenAiModelFallbackModelsItem.Gpt41106PreviewFrance, "gpt-4-1106-preview:france" },
        { OpenAiModelFallbackModelsItem.Gpt41106PreviewIndia, "gpt-4-1106-preview:india" },
        { OpenAiModelFallbackModelsItem.Gpt41106PreviewNorway, "gpt-4-1106-preview:norway" },
        {
            OpenAiModelFallbackModelsItem.Gpt41106PreviewSwedencentral,
            "gpt-4-1106-preview:swedencentral"
        },
        { OpenAiModelFallbackModelsItem.Gpt41106PreviewUk, "gpt-4-1106-preview:uk" },
        { OpenAiModelFallbackModelsItem.Gpt41106PreviewWestus, "gpt-4-1106-preview:westus" },
        { OpenAiModelFallbackModelsItem.Gpt41106PreviewWestus3, "gpt-4-1106-preview:westus3" },
        { OpenAiModelFallbackModelsItem.Gpt40613Canadaeast, "gpt-4-0613:canadaeast" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo0125Canadaeast, "gpt-3.5-turbo-0125:canadaeast" },
        {
            OpenAiModelFallbackModelsItem.Gpt35Turbo0125Northcentralus,
            "gpt-3.5-turbo-0125:northcentralus"
        },
        {
            OpenAiModelFallbackModelsItem.Gpt35Turbo0125Southcentralus,
            "gpt-3.5-turbo-0125:southcentralus"
        },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo1106Canadaeast, "gpt-3.5-turbo-1106:canadaeast" },
        { OpenAiModelFallbackModelsItem.Gpt35Turbo1106Westus, "gpt-3.5-turbo-1106:westus" },
    };

    public override OpenAiModelFallbackModelsItem Read(
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
        OpenAiModelFallbackModelsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiModelFallbackModelsItem ReadAsPropertyName(
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
        OpenAiModelFallbackModelsItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
