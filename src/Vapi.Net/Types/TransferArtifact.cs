using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TransferArtifact : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The transfer destination (phone number or SIP URI).
    /// </summary>
    [JsonPropertyName("destination")]
    public required object Destination { get; set; }

    /// <summary>
    /// The transfer mode (e.g. warm-transfer-experimental, blind-transfer).
    /// </summary>
    [JsonPropertyName("mode")]
    public TransferArtifactMode? Mode { get; set; }

    /// <summary>
    /// Flat-text transcript / announcement preview of the transfer.
    /// </summary>
    [JsonPropertyName("transcript")]
    public string? Transcript { get; set; }

    /// <summary>
    /// The terminal status of the transfer, rendered as the status line.
    /// </summary>
    [JsonPropertyName("status")]
    public TransferArtifactStatus? Status { get; set; }

    /// <summary>
    /// The agent↔operator conversation captured during a
    /// warm-transfer-experimental, rendered as bubbles.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<UserMessage, SystemMessage, BotMessage, ToolCallMessage, ToolCallResultMessage>
    >? Messages { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
