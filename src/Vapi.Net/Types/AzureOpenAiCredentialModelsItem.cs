using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AzureOpenAiCredentialModelsItem>))]
public enum AzureOpenAiCredentialModelsItem
{
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
