using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TavusVoice
{
    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<string, string> VoiceId { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    /// <summary>
    /// This is the unique identifier for the persona that the replica will use in the conversation.
    /// </summary>
    [JsonPropertyName("personaId")]
    public string? PersonaId { get; set; }

    /// <summary>
    /// This is the url that will receive webhooks with updates regarding the conversation state.
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>
    /// This is the name for the conversation.
    /// </summary>
    [JsonPropertyName("conversationName")]
    public string? ConversationName { get; set; }

    /// <summary>
    /// This is the context that will be appended to any context provided in the persona, if one is provided.
    /// </summary>
    [JsonPropertyName("conversationalContext")]
    public string? ConversationalContext { get; set; }

    /// <summary>
    /// This is the custom greeting that the replica will give once a participant joines the conversation.
    /// </summary>
    [JsonPropertyName("customGreeting")]
    public string? CustomGreeting { get; set; }

    /// <summary>
    /// These are optional properties used to customize the conversation.
    /// </summary>
    [JsonPropertyName("properties")]
    public TavusConversationProperties? Properties { get; set; }

    /// <summary>
    /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackPlan? FallbackPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
