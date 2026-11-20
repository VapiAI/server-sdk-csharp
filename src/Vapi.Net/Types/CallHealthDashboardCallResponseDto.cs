using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardCallResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("callId")]
    public required string CallId { get; set; }

    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// Selected goal identity.
    /// </summary>
    [JsonPropertyName("goalId")]
    public required string GoalId { get; set; }

    /// <summary>
    /// The assistant version the call ran on; absent when it ran on none.
    /// </summary>
    [JsonPropertyName("assistantVersionId")]
    public string? AssistantVersionId { get; set; }

    /// <summary>
    /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// Classification state, named as in the coverage `classification` counters.
    /// </summary>
    [JsonPropertyName("assessmentState")]
    public required CallHealthDashboardCallResponseDtoAssessmentState AssessmentState { get; set; }

    /// <summary>
    /// The call's main failure category; absent when classification selected none.
    /// </summary>
    [JsonPropertyName("primaryCategoryKey")]
    public string? PrimaryCategoryKey { get; set; }

    /// <summary>
    /// The other selected categories, in ascending key order.
    /// </summary>
    [JsonPropertyName("otherCategoryKeys")]
    public IEnumerable<string> OtherCategoryKeys { get; set; } = new List<string>();

    /// <summary>
    /// Visible issues the call joined, in ascending ID order.
    /// </summary>
    [JsonPropertyName("issues")]
    public IEnumerable<CallHealthDashboardCallIssueDto> Issues { get; set; } =
        new List<CallHealthDashboardCallIssueDto>();

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
