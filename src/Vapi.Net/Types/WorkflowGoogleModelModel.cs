using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<WorkflowGoogleModelModel>))]
public enum WorkflowGoogleModelModel
{
    [EnumMember(Value = "gemini-2.5-pro")]
    Gemini25Pro,

    [EnumMember(Value = "gemini-2.5-flash")]
    Gemini25Flash,

    [EnumMember(Value = "gemini-2.5-flash-lite")]
    Gemini25FlashLite,

    [EnumMember(Value = "gemini-2.5-pro-preview-05-06")]
    Gemini25ProPreview0506,

    [EnumMember(Value = "gemini-2.5-flash-preview-05-20")]
    Gemini25FlashPreview0520,

    [EnumMember(Value = "gemini-2.5-flash-preview-04-17")]
    Gemini25FlashPreview0417,

    [EnumMember(Value = "gemini-2.0-flash-thinking-exp")]
    Gemini20FlashThinkingExp,

    [EnumMember(Value = "gemini-2.0-pro-exp-02-05")]
    Gemini20ProExp0205,

    [EnumMember(Value = "gemini-2.0-flash")]
    Gemini20Flash,

    [EnumMember(Value = "gemini-2.0-flash-lite")]
    Gemini20FlashLite,

    [EnumMember(Value = "gemini-2.0-flash-lite-preview-02-05")]
    Gemini20FlashLitePreview0205,

    [EnumMember(Value = "gemini-2.0-flash-exp")]
    Gemini20FlashExp,

    [EnumMember(Value = "gemini-2.0-flash-realtime-exp")]
    Gemini20FlashRealtimeExp,

    [EnumMember(Value = "gemini-1.5-flash")]
    Gemini15Flash,

    [EnumMember(Value = "gemini-1.5-flash-002")]
    Gemini15Flash002,

    [EnumMember(Value = "gemini-1.5-pro")]
    Gemini15Pro,

    [EnumMember(Value = "gemini-1.5-pro-002")]
    Gemini15Pro002,

    [EnumMember(Value = "gemini-1.0-pro")]
    Gemini10Pro,
}
