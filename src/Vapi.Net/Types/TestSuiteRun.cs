using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TestSuiteRun
{
    /// <summary>
    /// This is the current status of the test suite run.
    /// </summary>
    [JsonPropertyName("status")]
    public required TestSuiteRunStatus Status { get; set; }

    /// <summary>
    /// This is the unique identifier for the test suite run.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization this run belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the unique identifier for the test suite this run belongs to.
    /// </summary>
    [JsonPropertyName("testSuiteId")]
    public required string TestSuiteId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the test suite run was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the test suite run was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// These are the results of the tests in this test suite run.
    /// </summary>
    [JsonPropertyName("testResults")]
    public IEnumerable<TestSuiteRunTestResult> TestResults { get; set; } =
        new List<TestSuiteRunTestResult>();

    /// <summary>
    /// This is the name of the test suite run.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
