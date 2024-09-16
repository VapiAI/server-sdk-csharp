using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ModelCost
{
    /// <summary>
    /// This is the model that was used during the call.
    ///
    /// This matches one of the following:
    ///
    /// - `call.assistant.model`,
    /// - `call.assistantId->model`,
    /// - `call.squad[n].assistant.model`,
    /// - `call.squad[n].assistantId->model`,
    /// - `call.squadId->[n].assistant.model`,
    /// - `call.squadId->[n].assistantId->model`.
    /// </summary>
    [JsonPropertyName("model")]
    public object Model { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the number of prompt tokens used in the call. These should be total prompt tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
    /// </summary>
    [JsonPropertyName("promptTokens")]
    public required double PromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens generated in the call. These should be total completion tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
    /// </summary>
    [JsonPropertyName("completionTokens")]
    public required double CompletionTokens { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
