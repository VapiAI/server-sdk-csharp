using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record TranscriptPlan
{
    /// <summary>
    /// This determines whether the transcript is stored in `call.artifact.transcript`. Defaults to true.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This is the name of the assistant in the transcript. Defaults to 'AI'.
    ///
    /// Usage:
    ///
    /// - If you want to change the name of the assistant in the transcript, set this. Example, here is what the transcript would look like with `assistantName` set to 'Buyer':
    ///
    /// ```
    /// User: Hello, how are you?
    /// Buyer: I'm fine.
    /// User: Do you want to buy a car?
    /// Buyer: No.
    /// ```
    ///
    /// @default 'AI'
    /// </summary>
    [JsonPropertyName("assistantName")]
    public string? AssistantName { get; set; }

    /// <summary>
    /// This is the name of the user in the transcript. Defaults to 'User'.
    ///
    /// Usage:
    ///
    /// - If you want to change the name of the user in the transcript, set this. Example, here is what the transcript would look like with `userName` set to 'Seller':
    ///
    /// ```
    /// Seller: Hello, how are you?
    /// AI: I'm fine.
    /// Seller: Do you want to buy a car?
    /// AI: No.
    /// ```
    ///
    /// @default 'User'
    /// </summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}