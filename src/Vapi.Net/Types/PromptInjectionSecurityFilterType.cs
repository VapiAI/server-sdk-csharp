using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PromptInjectionSecurityFilterType>))]
public enum PromptInjectionSecurityFilterType
{
    [EnumMember(Value = "prompt-injection")]
    PromptInjection,
}
