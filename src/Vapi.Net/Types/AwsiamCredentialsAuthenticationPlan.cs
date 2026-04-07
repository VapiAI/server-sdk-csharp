using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AwsiamCredentialsAuthenticationPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// AWS Access Key ID. This is not returned in the API.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public required string AwsAccessKeyId { get; set; }

    /// <summary>
    /// AWS Secret Access Key. This is not returned in the API.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public required string AwsSecretAccessKey { get; set; }

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
