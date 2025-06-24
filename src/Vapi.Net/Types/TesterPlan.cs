using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TesterPlan
{
    /// <summary>
    /// Pass a transient assistant to use for the test assistant.
    ///
    /// Make sure to write a detailed system prompt for a test assistant, and use the {{test.script}} variable to access the test script.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// Pass an assistant id that can be access
    ///
    /// Make sure to write a detailed system prompt for the test assistant, and use the {{test.script}} variable to access the test script.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// Add any assistant overrides to the test assistant.
    ///
    /// One use case is if you want to pass custom variables into the test using variableValues, that you can then access in the script
    /// and rubric using {{varName}}.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
