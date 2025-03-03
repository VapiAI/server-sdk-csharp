using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateTestSuiteDto
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
