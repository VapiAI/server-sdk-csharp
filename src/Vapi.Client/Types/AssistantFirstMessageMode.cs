using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

[JsonConverter(typeof(StringEnumSerializer<AssistantFirstMessageMode>))]
public enum AssistantFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}