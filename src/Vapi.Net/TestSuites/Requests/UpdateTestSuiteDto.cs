using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateTestSuiteDto
{
    /// <summary>
    /// This is the name of the test suite.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the phone number ID associated with this test suite.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// Override the default tester plan by providing custom assistant configuration for the test agent.
    ///
    /// We recommend only using this if you are confident, as we have already set sensible defaults on the tester plan.
    /// </summary>
    [JsonPropertyName("testerPlan")]
    public TesterPlan? TesterPlan { get; set; }

    /// <summary>
    /// These are the configuration for the assistant / phone number that is being tested.
    /// </summary>
    [JsonPropertyName("targetPlan")]
    public TargetPlan? TargetPlan { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
