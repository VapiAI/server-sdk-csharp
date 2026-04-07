using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AwsStsAuthenticationSession : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the assumed role user
    /// </summary>
    [JsonPropertyName("assumedRoleUser")]
    public AwsStsAssumeRoleUser? AssumedRoleUser { get; set; }

    /// <summary>
    /// This is the credentials for the AWS STS assume role
    /// </summary>
    [JsonPropertyName("credentials")]
    public AwsStsCredentials? Credentials { get; set; }

    /// <summary>
    /// This is the size of the policy
    /// </summary>
    [JsonPropertyName("packedPolicySize")]
    public double? PackedPolicySize { get; set; }

    /// <summary>
    /// This is the sourced ID entity
    /// </summary>
    [JsonPropertyName("sourcedIDEntity")]
    public string? SourcedIdEntity { get; set; }

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
