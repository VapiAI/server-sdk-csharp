using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackGoogleTranscriberModel>))]
public enum FallbackGoogleTranscriberModel
{
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
