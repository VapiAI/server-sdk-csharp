using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiModelFallbackModelsItem>))]
public enum OpenAiModelFallbackModelsItem
{
    [EnumMember(Value = "gpt-5.1")]
    Gpt51,

    [EnumMember(Value = "gpt-5.1-chat-latest")]
    Gpt51ChatLatest,

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

    [EnumMember(Value = "gpt-4-1106-preview:australia")]
    Gpt41106PreviewAustralia,

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
