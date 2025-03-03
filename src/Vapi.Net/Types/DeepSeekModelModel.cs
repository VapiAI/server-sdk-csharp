using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<DeepSeekModelModel>))]
public enum DeepSeekModelModel
{
    [EnumMember(Value = "deepseek-chat")]
    DeepseekChat,

    [EnumMember(Value = "deepseek-reasoner")]
    DeepseekReasoner,
}
