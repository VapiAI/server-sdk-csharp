using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateTrafficAllocationDto
{
    /// <summary>
    /// The assistant whose calls this allocation splits.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// 'explicit' splits calls across targets, and is inferred when targets is sent. 'follow-latest' sends every call to the newest published version and is how you stop splitting; it must be sent explicitly.
    /// </summary>
    [JsonPropertyName("allocationIntent")]
    public CreateTrafficAllocationDtoAllocationIntent? AllocationIntent { get; set; }

    /// <summary>
    /// The versions to split calls across. Omit to stop splitting (with allocationIntent 'follow-latest'). Order in this array is the selection order (position).
    /// </summary>
    [JsonPropertyName("targets")]
    public IEnumerable<CreateTrafficAllocationTargetDto>? Targets { get; set; }

    /// <summary>
    /// Optional concurrency guard. Omit it and the write applies unconditionally (last write wins, matching every other Vapi update surface). Provide the id of the allocation you last read and the write applies only while that allocation is still governing; any mismatch is a 409 carrying the actual current id.
    /// </summary>
    [JsonPropertyName("expectedCurrentAllocationId")]
    public string? ExpectedCurrentAllocationId { get; set; }

    /// <summary>
    /// An optional note explaining why you made this change.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
